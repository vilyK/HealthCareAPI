﻿namespace HealthCare.BusinessLayer.Services
{
    using System.Linq;
    using System.Threading.Tasks;
    using AutoMapper;

    using Contracts.Interfaces;
    using Contracts.Models.MedicalCenterAccount.Requests;
    using Contracts.Models.MedicalCenterAccount.Responses;
    using DataLayer;
    using Exceptions;
    using Extensions;
    using Interfaces;
    using Utilities.Enums;
    using Utilities.Helpers;

    public class MedicalCenterService : IMedicalCenterService
    {
        private readonly ISessionResolver _sessionResolver;
        private readonly IMapper _mapper;
        private readonly HealthCareDbContext _dbContext;

        public MedicalCenterService(ISessionResolver sessionResolver, HealthCareDbContext dbContext, IMapper mapper)
        {
            _sessionResolver = sessionResolver;
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<PersistMedicalCenterDataResponse> PersistMedicalCenterData(PersistMedicalCenterDataRequest request)
        {
            var medicalCenterInfo = _dbContext.MedicalCenterInfos.SingleOrDefault(x => x.UserId == _sessionResolver.SessionInfo.UserId);
            ValidationUtils.ValidateAndThrow<DataMismatchException>(()=> medicalCenterInfo == null);

            var medicalCenterCurrentDepartments = _dbContext.MedicalCenterDepartments
                .Where(x => x.MedicalCenterInfoId == medicalCenterInfo.Id && x.IsDeleted == false)
                .ToList();

            var dbModel = _mapper.Map(request.Data, medicalCenterInfo);
            var departments = request.Data.MedicalCenterDepartments.EmptyIfNull().Distinct();

            dbModel.AddDepartments(departments, medicalCenterCurrentDepartments, medicalCenterInfo.Id);

            _dbContext.PersistModel(dbModel, DatabaseOperation.Update);
            await _dbContext.SaveChangesAsync();

            return new PersistMedicalCenterDataResponse
            {
                Token = _sessionResolver.SessionInfo.NewToken
            };
        }
    }
}
