namespace HealthCare.DataLayer.Entities.MedicalMan
{
    using System.ComponentModel.DataAnnotations.Schema;

    using Base;
    using UserAccount;
    using Utilities.Enums;

    public class Referral : SystemData
    {
        public RelationType Relation { get; set; }

        public string Comment { get; set; }

        public int RecipientId { get; set; }

        [ForeignKey("RecipientId")]
        [InverseProperty("ReceivedReferrals")]
        public User Recipient { get; set; }

        public int SenderId { get; set; }

        [ForeignKey("SenderId")]
        [InverseProperty("SentReferrals")]
        public User Sender { get; set; }
    }
}
