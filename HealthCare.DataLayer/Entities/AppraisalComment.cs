﻿namespace HealthCare.DataLayer.Entities
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Base;

    public class AppraisalComment : SystemData
    {
        public int RecipientId { get; set; }

        [ForeignKey("RecipientId")]
        public User.User Recipient { get; set; }

        public int SenderId { get; set; }

        [ForeignKey("SenderId")]
        public User.User Sender { get; set; }

        public string Comment { get; set; }
    }
}