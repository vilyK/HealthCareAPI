namespace HealthCare.Validation.Extensions
{
    using System.Collections.Generic;

    using Contracts.Models.Appraisal;
    using Utilities.Enums;

    public static class CommonExtensions
    {
        public static bool HasValidAppraisal(this List<AppraisalData> appraisals, AppraisalRecipientType recipientType)
        {
            var validAppraisalTypes = new List<AppraisalType>();

            const int minValueAppraisal = 0;
            const int maxValueAppraisal = 6;

            switch (recipientType)
            {
                case AppraisalRecipientType.Doctor:
                    validAppraisalTypes = new List<AppraisalType>
                    {
                        AppraisalType.Attitude, AppraisalType.Conditions, AppraisalType.CommonValuation, AppraisalType.WaitingTime, AppraisalType.TreatmentEffectiveness
                    };
                    break;
                case AppraisalRecipientType.MedicalCenter:
                    validAppraisalTypes = new List<AppraisalType>
                    {
                        AppraisalType.Attitude, AppraisalType.Conditions, AppraisalType.Hygiene, AppraisalType.CommonValuation
                    };
                    break;
            }

            foreach (var item in appraisals)
            {
                if (!validAppraisalTypes.Contains(item.AppraisalType) 
                    || item.AppraisalValue < minValueAppraisal 
                    || item.AppraisalValue > maxValueAppraisal)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
