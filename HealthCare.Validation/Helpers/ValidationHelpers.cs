namespace HealthCare.Validation.Helpers
{
    using System.Collections.Generic;
    using System.Net.Mail;
    using System.Text.RegularExpressions;
   
    using Contracts.Models.Appraisal.Data;
    using Contracts.Models.UserAccount.Data;
    using Utilities.Enums;
    using Utilities.Extensions;

    public static class ValidationHelpers
    {
        public static bool IsValidEmail(this List<EmailData> emails)
        {
            foreach (var email in emails)
            {
                var emailsAddress = new MailAddress(email.EmailAddress);

                if (emailsAddress.Address != email.EmailAddress)
                    return false;
            }

            return true;
        }

        public static bool IsValidPhoneNumber(this List<PhoneData> phonesNumbers)
        {
            foreach (var phone in phonesNumbers)
            {
                if (!Regex.Match(phone.Number, @"^(\+[0-9]{10,20})$").Success)
                {
                    return false;
                }
            }

            return true;
        }

        public static bool HasValidAppraisal(this List<AppraisalData> appraisals, AppraisalRecipientType recipientType)
        {
            const int minValueAppraisal = 0;
            const int maxValueAppraisal = 6;

            var validAppraisalTypes = recipientType.GetValidAppraisalTypes();

            foreach (var item in appraisals)
            {
                if (!validAppraisalTypes.Contains(item.AppraisalType) || !item.AppraisalValue.Between(minValueAppraisal, maxValueAppraisal))
                    return false;
            }

            return true;
        }
    }
}
