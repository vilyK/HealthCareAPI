namespace HealthCare.Validation.ModelValidators.Example
{
    using Common.Models.CalculateBets.Requests;
    using Extensions.RegularBet;
    using FluentValidation;

    public class CalculateBetValidator : BaseValidator<CalculateBetsRequest>
    {
        public CalculateBetValidator()
        {
            ValidatorOptions.CascadeMode = CascadeMode.StopOnFirstFailure;

            RuleFor(request => request)
                .HasAnyPassedArray();

            RuleFor(request => request.Selections)
                .HasDuplicatedIds()
                .HasValidSelectionsUnderMaxNeeded();

            RuleFor(request => request.SelectionsForForecast)
                .HasDuplicatedIds()
                .HasValidSelectionsForForecast()
                .HasValidSelectionsUnderMaxNeeded();

            RuleFor(request => request.SelectionsForTricast)
                .HasDuplicatedIds()
                .HasValidSelectionsForTricast()
                .HasValidSelectionsUnderMaxNeeded();

            RuleForEach(request => request.Selections)
                .HasValidSelectionId()
                .EncodedIdMustBeValid()
                .HasValidRacingCastBetPositionPassed();

            RuleForEach(request => request.SelectionsForForecast)
                .HasValidSelectionId()
                .EncodedIdMustBeValid()
                .HasSetRacingCastBetPosition()
                .HasValidRacingCastBetPosition();

            RuleForEach(request => request.SelectionsForTricast)
                .HasValidSelectionId()
                .EncodedIdMustBeValid()
                .HasSetRacingCastBetPosition()
                .HasValidRacingCastBetPosition();
        }
