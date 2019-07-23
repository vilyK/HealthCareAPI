namespace HealthCare.DataLayer.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    using Base;
    using Utilities.Enums;

    public class Appraisal : SystemData
    {
        public int Id { get; set; }

        public int RecipientId { get; set; }

        [ForeignKey("RecipientId")]
        public User.User Recipient { get; set; }

        public int SenderId { get; set; }

        [ForeignKey("SenderId")]
        public User.User Sender { get; set; }

        public AppraisalType AppraisalType { get; set; }

        public int Value { get; set; }

        public string Comment { get; set; }

        public DateTime AppraisalDate { get; set; }
    }
}
