namespace HealthCare.Validation.Helpers
{
    using System.Collections.Generic;
    using System.Linq;
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

            return emails.All(email => regexValidator.IsMatch(email.EmailAddress));
        }

        public static bool HasValidPhoneNumbers(this List<PhoneData> phonesNumbers)
        {
            var regexValidator = new Regex(@"^(\+?[0-9]{8,20})$");

            return phonesNumbers.All(phone => regexValidator.IsMatch(phone.Number));
        }

        public static bool HasValidAppraisal(this List<AppraisalData> appraisals, AppraisalRecipientType recipientType)
        {
            const int minValueAppraisal = 0;
            const int maxValueAppraisal = 6;

            var validAppraisalTypes = recipientType.GetValidAppraisalTypes();

            return appraisals.All(item => validAppraisalTypes.Contains(item.AppraisalType) 
                                          && item.AppraisalValue.Between(minValueAppraisal, maxValueAppraisal));
        }
    }
}
