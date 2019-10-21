namespace HealthCare.Validation.Helpers
{
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
   
    using Contracts.Models.Appraisal.Data;
    using Contracts.Models.UserAccount.Data;
    using Utilities.Enums;
    using Utilities.Extensions;

    public static class ValidationHelpers
    {
        public static bool HasValidEmails(this List<EmailData> emails)
        {
            var regexValidator = new Regex(@"^[-!#$%&'*+/0-9=?A-Z^_a-z{|}~](\.?[-!#$%&'*+/0-9=?A-Z^_a-z{|}~])*@[a-zA-Z](-?[a-zA-Z0-9])*(\.[a-zA-Z](-?[a-zA-Z0-9])*)+$");

            foreach (var email in emails)
            {
                if (!regexValidator.IsMatch(email.EmailAddress)) 
                    return false;
            }

            return true;
        }

        public static bool HasValidPhoneNumbers(this List<PhoneData> phonesNumbers)
        {
            var regexValidator = new Regex(@"^(\+?[0-9]{8,20})$");

            foreach (var phone in phonesNumbers)
            {
                if (!regexValidator.IsMatch(phone.Number))
                    return false;
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
