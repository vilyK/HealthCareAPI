namespace HealthCare.DataLayer.Entities.MedicalMan
{
    using System.ComponentModel.DataAnnotations.Schema;

    using Base;
    using User;
    using Utilities.Enums;

    public class Referral : SystemData
    {
        public int Id { get; set; }
    
        public RelationType Relation { get; set; }

        public string Comment { get; set; }

        public int RecipientId { get; set; }

        [ForeignKey("RecipientId")]
        public User Recipient { get; set; }

        public int SenderId { get; set; }

        [ForeignKey("SenderId")]
        public User Sender { get; set; }
    }
}
