namespace HealthCare.Models.DatabaseModels.MedicalMan
{
    using Enums;
    using User;

    public class Referral
    {
        public int Id { get; set; }

        public int RecipientId { get; set; }
        public User Recipient { get; set; }

        public int SenderId { get; set; }
        public User Sender { get; set; }

        public RelationType Relation { get; set; }
    }
}
