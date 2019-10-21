namespace HealthCare.DataLayer.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Entities.MedicalMan;
    
    public class ReferralConfig : IEntityTypeConfiguration<Referral>
    {
        public void Configure(EntityTypeBuilder<Referral> modelBuilder)
        {
            modelBuilder
                .HasOne(e => e.Recipient)
                .WithMany(e => e.ReceivedReferrals)
                .HasForeignKey(e => e.RecipientId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder
                .HasOne(e => e.Sender)
                .WithMany(e => e.SentReferrals)
                .HasForeignKey(e => e.SenderId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
