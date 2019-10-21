namespace HealthCare.DataLayer.Entities.UserAccount
{
    using System.ComponentModel.DataAnnotations.Schema;
   
    using Base;

    public class AppraisalComment : SystemData
    {
        public int RecipientId { get; set; }

        [ForeignKey("RecipientId")]
        public UserAccount.User Recipient { get; set; }

        public int SenderId { get; set; }

        [ForeignKey("SenderId")]
        public UserAccount.User Sender { get; set; }

        public string Comment { get; set; }
    }
}
