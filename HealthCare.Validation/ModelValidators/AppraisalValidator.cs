﻿namespace HealthCare.Validation.ModelValidators
{
    using FluentValidation;

    using Contracts.Models.Appraisal.Requests;
    using Extensions;
    
    public class AppraisalValidator : BaseValidator<SetAppraisalRequest>
    {
        public AppraisalValidator()
        {
            CascadeMode = CascadeMode.StopOnFirstFailure;

            RuleFor(request => request)
                .HasValidAppraisals();
        }
    }
}
