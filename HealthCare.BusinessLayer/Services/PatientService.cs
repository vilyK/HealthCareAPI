namespace HealthCare.BusinessLayer.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using AutoMapper;

    using Contracts.Interfaces;
    using Contracts.Models.Appointment.Responses;
    using Contracts.Models.Common;
    using Contracts.Models.CommonMedicalData;
    using Contracts.Models.OutpatientCard.Data;
    using Contracts.Models.OutpatientCard.Responses;
    using Contracts.Models.PatientAccount.Data;
    using Contracts.Models.PatientAccount.Requests;
    using Contracts.Models.PatientAccount.Responses;
    using DataLayer;
    using DataLayer.Entities.MedicalData;
    using Exceptions;
    using Extensions;
    using Interfaces;
    using Microsoft.AspNetCore.Http;
    using Microsoft.EntityFrameworkCore;
    using Utilities.Enums;
    using Utilities.Enums.Common;
    using Utilities.Helpers;

    public class PatientService : IPatientService
    {
        private readonly IMapper _mapper;
        private readonly HealthCareDbContext _dbContext;
        private readonly ISessionResolver _sessionResolver;
        private readonly IMedicalDataService _medicalDataService;

        public PatientService(IMapper mapper,
            HealthCareDbContext dbContext,
            ISessionResolver sessionResolver,
            IMedicalDataService medicalDataService)
        {
            _mapper = mapper;
            _dbContext = dbContext;
            _sessionResolver = sessionResolver;
            _medicalDataService = medicalDataService;
        }

        public async Task<TokenData> PersistMedicalProfile(PersistMedicalProfileRequest request)
        {
            var patientInfoId = PersistPatientPersonalData(request.PatientData);
            var medicalProfileId = PersistMedicalProfileData(request.MedicalData, patientInfoId);

            _medicalDataService.PersistMedicalDataRelatedEntities<IllnessData, Illness>(request.Illnesses.EmptyIfNull(), medicalProfileId, DocumentType.MedicalProfile, DiseaseType.Illness);
            
            //if(files.Any())
            //    _medicalDataService.PersistMedicalTests(files, medicalProfileId, DocumentType.MedicalProfile);

            await _dbContext.SaveChangesAsync();

            return new TokenData
            {
                Token = _sessionResolver.SessionInfo.NewToken
            };
        }

        public async Task<GetPatientByEgnResponse> GetPatientByEng(int egn)
        {
            // TODO: change it to single or default
            var patientDb = await _dbContext.PatientInfos
                .Where(x => x.EGN == egn)
                .Include(x => x.Patient)
                .ThenInclude(pat => pat.UserContact.Emails)
                .ThenInclude(pat => pat.UserContact.Phones)
                .ThenInclude(pat => pat.UserContact.Addresses)
                .ThenInclude(add => add.City)
                .FirstOrDefaultAsync();

           var patient = _mapper.Map<PatientInfoData>(patientDb);
           //var patient = new PatientInfoData
           // {
           //     PatientInfoId = patientDb.Id,
           //     Name = patientDb.Name,
           //     Gender = patientDb.Gender,
           //     Age = patientDb.BirthDate.Year - DateTime.UtcNow.Year,
           //     Email = patientDb.Patient.UserContact.Emails[0].EmailAddress,
           //    // Address = $"{patientDb.Patient.UserContact.Addresses[0].StreetAddress}, {patientDb.Patient.UserContact.Addresses[0].City.Name}",
           //     PhoneNumber = patientDb.Patient.UserContact.Phones[0].Number,
           //     BirthDate = patientDb.BirthDate
           // };

            // id-то е PatientInfoId
            return new GetPatientByEgnResponse
            {
                Token = _sessionResolver.SessionInfo.NewToken,
                Patient = patient,
            };
        }

        public async Task<GetPatientAppointmentsResponse> GetAppointments(int patientInfoId)
        {
            var patientInfo = await _dbContext.PatientInfos.SingleOrDefaultAsync(patient => patient.Id == patientInfoId);
            ValidationUtils.ValidateAndThrow<DataMismatchException>(() => patientInfo == null);

            var appointments = _dbContext.Appointments
                .Where(app => app.PatientId == patientInfo.UserId)
                .Include(app => app.Doctor)
                .ThenInclude(doc => doc.MedicalManInfo)
                .ThenInclude(info => info.Specialties)
                .ThenInclude(spec => spec.Specialty)
                .Include(app => app.Patient)
                .OrderByDescending(app => app.AppointmentDate)
                .ToList();

            var results = new List<PatientAppointment>();

            foreach (var app in appointments)
            {
                var result = new PatientAppointment
                {
                    Id = app.Id,
                    AppointmentHour = app.AppointmentDate,
                    Status = app.Status,
                    DoctorName = app.Doctor.MedicalManInfo.Name,
                    Specialty = app.Doctor.MedicalManInfo.Specialties[0].Specialty.Name,
                    IsCurrentDoctor = app.Doctor.Id == _sessionResolver.SessionInfo.UserId,
                };

                results.Add(result);
            }

            return new GetPatientAppointmentsResponse
            {
                Token = _sessionResolver.SessionInfo.NewToken,
                Appointments = results
            };
        }

        public GetOutPatientCardsResponse GetOutPatientCards(int patientInfoId)
        {
            var patientInfo = _dbContext.PatientInfos.SingleOrDefault(info => info.Id == patientInfoId);

            ValidationUtils.ValidateAndThrow<DataMismatchException>(() => patientInfo == null);

            var patientUserId = patientInfo.UserId;

            var outPatientCardDbModels = _dbContext.OutpatientCards
                .Where(card => card.Patient.Id == patientUserId)
                .ToList();

            var result = _mapper.Map<List<OutPatientCardInfo>>(outPatientCardDbModels);

            return new GetOutPatientCardsResponse
            {
                Token = _sessionResolver.SessionInfo.NewToken,
                OutPatientCardInfo = result
            };
        }

        private int PersistPatientPersonalData(PatientGeneralData requestPatientData)
        {
            var patientInfo = _dbContext.PatientInfos.SingleOrDefault(x => x.UserId == _sessionResolver.SessionInfo.UserId);

            ValidationUtils.ValidateAndThrow<DataMismatchException>(() => patientInfo == null);

            var dbModel = _mapper.Map(requestPatientData, patientInfo);
            dbModel.UserId = _sessionResolver.SessionInfo.UserId;

           return _dbContext.PersistModel(dbModel, DatabaseOperation.Update);
        }

        private int PersistMedicalProfileData(MedicalProfileGeneralData data, int patientInfoId)
        {
            var dbModel = _dbContext.MedicalProfiles.SingleOrNew(x => x.PatientInfoId == patientInfoId);

            dbModel = _mapper.Map(data, dbModel);
            dbModel.PatientInfoId = patientInfoId;

            var dbOperation = dbModel.Id.GetDbOperation();
            var medicalProfileId = _dbContext.PersistModel(dbModel, dbOperation);

            return medicalProfileId;
        }
    }
}