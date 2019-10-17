namespace HealthCare.BusinessLayer.Services
{
    using System.Linq;
    using System.Threading.Tasks;

    using Contracts.Interfaces;
    using Contracts.Models.Appraisal.Requests;
    using Contracts.Models.Appraisal.Responses;
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

        public AppraisalService(HealthCareDbContext dbContext, ISessionResolver sessionResolver)
        {
            _dbContext = dbContext;
            _sessionResolver = sessionResolver;
        }

        public async Task<SetAppraisalResponse> GiveAppraisals(SetAppraisalRequest request)
        {
            var recipientExists = _dbContext.Users
                .Any(x => (request.RecipientType == AppraisalRecipientType.Doctor && x.Id == request.RecipientId && x.RoleType == RoleType.Doctor)
                          || (request.RecipientType == AppraisalRecipientType.MedicalCenter && x.Id == request.RecipientId && x.RoleType == RoleType.MedicalCenter));
            ValidationUtils.ValidateAndThrow<DataMismatchException>(() => !recipientExists);

            await InsertAppraisals(request);

            return new SetAppraisalResponse
            {
                Token = _sessionResolver.SessionInfo.NewToken,
            };
        }

        private async Task InsertAppraisals(SetAppraisalRequest request)
        {
            var senderId = _sessionResolver.SessionInfo.UserId;

            AddAppraisalComment(request.AppraisalComment, request.RecipientId, senderId);

            foreach (var appraisal in request.Appraisals)
            {
                var voteExists = _dbContext.Appraisals.Any(x => x.SenderId == senderId
                                                                && x.RecipientId == request.RecipientId
                                                                && x.AppraisalType == appraisal.AppraisalType);

                ValidationUtils.ValidateAndThrow<OperationNotAllowedException>(() => voteExists);

                // ?? should be in AutoMapper -> if not, remove mapping profile!
                var dbModel = new Appraisal
                {
                    AppraisalType = appraisal.AppraisalType,
                    Value = appraisal.AppraisalValue,
                    SenderId = senderId,
                    RecipientId = request.RecipientId,
                };

                _dbContext.PersistModel(dbModel, DatabaseOperation.Insert);

                await _dbContext.SaveChangesAsync();
            }
        }

        private void AddAppraisalComment(string comment, int recipientId, int senderId)
        {
            var commentExists = _dbContext.AppraisalComments.Any(x => x.SenderId == senderId  && x.RecipientId == recipientId);
            ValidationUtils.ValidateAndThrow<OperationNotAllowedException>(() => commentExists);

            // ?? should be in AutoMapper -> if not, remove mapping profile!
            var appraisalComment = new AppraisalComment
            {
                SenderId = senderId,
                RecipientId = recipientId,
                Comment = comment
            };

            _dbContext.Add(appraisalComment);
        }
    }
}
