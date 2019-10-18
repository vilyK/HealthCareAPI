namespace HealthCare.Validation.Helpers
{
    using System.Collections.Generic;
    using System.Net.Mail;
    using System.Text.RegularExpressions;
    using Contracts.Models.Appraisal;
    using Contracts.Models.UserAccount.Data;
    using Utilities.Enums;

    public static class ValidationHelpers
    {
        public static bool IsValidEmail(this List<EmailData> emails)
        {
            foreach (var email in emails)
            {
                var emailsAddress = new MailAddress(email.EmailAddress);

                if (emailsAddress.Address != email.EmailAddress)
                {
                    return false;
                }
            }

            return true;
        }

        public static bool IsValidPhoneNumber(this List<PhoneData> phonesNumbers)
        {
            foreach (var number in phonesNumbers)
            {
                if (!Regex.Match(number.Number, @"^(\+[0-9]{10,20})$").Success)
                {
                    return false;
                }
            }
            return true;
        }

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
