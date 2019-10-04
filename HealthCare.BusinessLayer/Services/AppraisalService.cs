namespace HealthCare.BusinessLayer.Services
{
    using System.Linq;
    using System.Threading.Tasks;
    using AutoMapper;
    using Contracts.Interfaces;
    using Contracts.Models.Appraisal;
    using DataLayer;
    using DataLayer.Entities;
    using Extensions;
    using Interfaces;
    using Utilities.Enums;
    using Utilities.Exceptions;

    public class AppraisalService : IAppraisalService
    {
        private readonly HealthCareDbContext _dbContext;
        private readonly ISessionResolver _sessionResolver;
        private IMapper _mapper;

        public AppraisalService(HealthCareDbContext dbContext, ISessionResolver sessionResolver, IMapper mapper)
        {
            _dbContext = dbContext;
            _sessionResolver = sessionResolver;
            _mapper = mapper;
        }

        public async Task<SetAppraisalResponse> SetDoctorAppraisals(SetAppraisalRequest request)
        {
            var doctorExists = _dbContext.Users.Any(x => x.Id == request.RecipientId && x.RoleType == RoleType.Doctor);
            ValidationUtils.ValidateAndThrow<IncorrectUserDataException>(() => !doctorExists);

            // check if user has already voted for this doctor 
            // available appraisals 1, 2, 4, 5, 6
            // should be moved to fluent validation
            //var availableAppraisalTypes = new List<AppraisalType>
            //    {
            //        AppraisalType.Attitude,
            //        AppraisalType.Conditions,
            //        AppraisalType.CommonValuation,
            //        AppraisalType.WaitingTime,
            //        AppraisalType.TreatmentEffectiveness
            //    };

            //var appraisalTypeIsValid = availableAppraisalTypes.Contains(appraisal.AppraisalType);

            SetAppraisal(request);

            await _dbContext.SaveChangesAsync();

            return new SetAppraisalResponse
            {
                Token = _sessionResolver.SessionInfo.NewToken,
            };
        }

        public async Task<SetAppraisalResponse> SetMedicalCenterAppraisals(SetAppraisalRequest request)
        {
            // check if recipient is a medical center
            var medicalCenterExists = _dbContext.Users.Any(x => x.Id == request.RecipientId && x.RoleType == RoleType.MedicalCenter);
            ValidationUtils.ValidateAndThrow<IncorrectUserDataException>(() => !medicalCenterExists);

            SetAppraisal(request);

            return new SetAppraisalResponse
            {
                Token = _sessionResolver.SessionInfo.NewToken,
            };
        }

        private void SetAppraisal(SetAppraisalRequest request)
        {
            var senderId = _sessionResolver.SessionInfo.UserId;

            foreach (var appraisal in request.Appraisals)
            {
                var voteExists = _dbContext.Appraisals.Any(x => x.SenderId == senderId
                                                                && x.RecipientId == request.RecipientId
                                                                && x.AppraisalType == appraisal.AppraisalType);

               

                ValidationUtils.ValidateAndThrow<OperationNotAllowedException>(() => voteExists);

                var dbModel = _mapper.Map<Appraisal>(appraisal);
                dbModel.SenderId = senderId;

                _dbContext.PersistModel(dbModel, DatabaseOperation.Insert);
            }
        }
    }
}
