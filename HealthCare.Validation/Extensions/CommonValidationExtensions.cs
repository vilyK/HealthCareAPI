namespace HealthCare.Validation.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Contracts.Models.Appraisal.Requests;
    using Contracts.Models.MedicalCenterAccount.Data;
    using Contracts.Models.UserAccount.Data;
    using FluentValidation;
    using Helpers;
    using Interfaces;
    using Utilities.Enums;
    using Utilities.Extensions;

    public static class CommonValidationExtensions
    {
        public static IRuleBuilderOptions<T, TModel> VerifyName<T, TModel>(this IRuleBuilder<T, TModel> ruleBuilder)
            where TModel : IName
        {
            return ruleBuilder.Must(request => request.Name.Length.Between(4, 70))
                .WithMessage("Invalid name.")
                .WithErrorCode("InvalidName");
        }

        public static IRuleBuilderOptions<T, List<ImageData>> HasValidMainImagesCount<T>(this IRuleBuilder<T, List<ImageData>> ruleBuilder)
        {
            return ruleBuilder.Must(images => images.Count(img => img.IsMain) <= 1)
                .WithMessage("Invalid main images count in request.")
                .WithErrorCode("InvalidMainImgCount");
        }

        public static IRuleBuilderOptions<T, List<DateTime>> HasNotRepeatedHours<T>(this IRuleBuilder<T, List<DateTime>> ruleBuilder)
        {
            return ruleBuilder.Must(hours => hours.Count == hours.Distinct().Count())
                .WithMessage("Your request contains hours with same values.")
                .WithErrorCode("InvalidAppointmentHours");
        }

        public static IRuleBuilderOptions<T, SetAppraisalRequest> HasValidAppraisals<T>(this IRuleBuilder<T, SetAppraisalRequest> ruleBuilder)
        {
            return ruleBuilder.Must(appraisals => appraisals.Appraisals.HasValidAppraisal(appraisals.RecipientType))
                .WithMessage("Appraisal types or value are invalid")
                .WithErrorCode("InvalidAppraisals");
        }

        public static IRuleBuilderOptions<T, MedicalCenterData> VerifyType<T>(this IRuleBuilder<T, MedicalCenterData> ruleBuilder)
        {
            return ruleBuilder.Must(center => Enum.IsDefined(typeof(MedicalCenterType), center.Type))
                .WithMessage("Medical center type is invalid.")
                .WithErrorCode("InvalidType");
        }
    }
}
