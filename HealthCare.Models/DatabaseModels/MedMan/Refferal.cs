namespace HealthCare.Models.DatabaseModels.MedMan
{
    using User;

    public class Refferal
    {
        public int Id { get; set; }

        public int RecipientId { get; set; }
        public User Recipient { get; set; }

        public int SenderId { get; set; }
        public User Sender { get; set; }

        public RelationType Relation { get;set }
    }
}
