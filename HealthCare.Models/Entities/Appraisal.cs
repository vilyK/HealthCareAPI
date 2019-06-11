namespace HealthCare.DataLayer.Entities
{
    using System;
    using Models.DatabaseModels.User;
    using Utilities.Enums;

    public class Appraisal
    {
        public int Id { get; set; }

        public int RecipientId { get; set; }
        public User Recipient { get; set; }

        public int SenderId { get; set; }
        public User Sender { get; set; }

        public AppraisalType AppraisalType { get; set; }
        public int Value { get; set; }

        public string Comment { get; set; }

        public DateTime AppraisalDate { get; set; }
    }
}
