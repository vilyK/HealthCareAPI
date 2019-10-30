namespace HealthCare.BusinessLayer.Services
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using Contracts.Interfaces;
    using Contracts.Models.Appointment.Requests;
    using Contracts.Models.Appointment.Responses;
    using DataLayer;
    using DataLayer.Entities.MedicalMan;
    using DataLayer.Entities.UserAccount;
    using Exceptions;
    using Extensions;
    using Interfaces;
    using Utilities.Enums;
    using Utilities.Helpers;

    public class AppointmentService : IAppointmentService
    {
        private readonly HealthCareDbContext _dbContext;
        private readonly ISessionResolver _sessionResolver;

        public AppointmentService(HealthCareDbContext dbContext, ISessionResolver sessionResolver)
        {
            _dbContext = dbContext;
            _sessionResolver = sessionResolver;
        }

        public async Task<RequestAppointmentResponse> RequestAppointment(RequestAppointmentRequest request)
        {
            var doctorInfo = _dbContext.MedicalManInfos.SingleOrDefault(x => x.Id == request.MedicalManInfoId);
            ValidationUtils.ValidateAndThrow<DataMismatchException>(() => doctorInfo == null);

            var appointmentHour = _dbContext.AppointmentHours
                .SingleOrDefault(x => x.Id == request.AppointmentHourId && x.AppointmentHourStatus == AppointmentHourStatus.Free);

            ValidationUtils.ValidateAndThrow<DataMismatchException>(
                () => appointmentHour == null || request.AppointmentDate < DateTime.Now); 

            var newAppointment = new Appointment
            {
                PatientId = _sessionResolver.SessionInfo.UserId,
                DoctorId = doctorInfo.UserId, 
                AppointmentDate = request.AppointmentDate,
                Status = AppointmentStatus.Pending
            };

            appointmentHour.AppointmentHourStatus = AppointmentHourStatus.Taken;

            _dbContext.PersistModel(newAppointment, DatabaseOperation.Insert);
            _dbContext.PersistModel(appointmentHour, DatabaseOperation.Update);
            
            await _dbContext.SaveChangesAsync();

            return new RequestAppointmentResponse
            {
                Token = _sessionResolver.SessionInfo.NewToken
            };
        }

        public async Task<RequestAppointmentResponse> ChangeAppointmentStatus(ChangeAppointmentStatusRequest request)
        {
            var appointment = _dbContext.Appointments.SingleOrDefault(x => x.Id == request.Id);
            ValidationUtils.ValidateAndThrow<DataMismatchException>(() => appointment == null);

            appointment.Status = request.Status;

            _dbContext.PersistModel(appointment, DatabaseOperation.Update);

            await _dbContext.SaveChangesAsync();

            return new RequestAppointmentResponse
            {
                Token = _sessionResolver.SessionInfo.NewToken
            };
        }

        public async Task<AddAppointmentHoursResponse> AddAppointmentHours(AddAppointmentHoursRequest request)
        {
            var medicalManInfoId = _dbContext.MedicalManInfos.SingleOrDefault(x => x.UserId == _sessionResolver.SessionInfo.UserId).Id;

            foreach (var hour in request.Hours)
            {
                var appointmentHour = new AppointmentHours
                {
                    MedicalManInfoId = medicalManInfoId,
                    AppointmentHour = hour
                };

                _dbContext.PersistModel(appointmentHour, DatabaseOperation.Insert);
            }

            await _dbContext.SaveChangesAsync();

            return new AddAppointmentHoursResponse
            {
                Token = _sessionResolver.SessionInfo.NewToken
            };
        }
    }
}
