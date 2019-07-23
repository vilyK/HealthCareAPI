﻿namespace HealthCare.DataLayer.Configurations
{
    using Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class AppraisalConfiguration : IEntityTypeConfiguration<Appraisal>
    {
        public void Configure(EntityTypeBuilder<Appraisal> modelBuilder)
        {
            modelBuilder
                .HasOne(e => e.Recipient)
                .WithMany(e => e.ReceivedAppraisals)
                .HasForeignKey(e => e.RecipientId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder
                .HasOne(e => e.Sender)
                .WithMany(e => e.SentAppraisals)
                .HasForeignKey(e => e.SenderId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
