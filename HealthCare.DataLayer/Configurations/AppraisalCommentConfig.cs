namespace HealthCare.DataLayer.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Entities.UserAccount;
    
    public class AppraisalCommentConfig : IEntityTypeConfiguration<AppraisalComment>
    {
        public void Configure(EntityTypeBuilder<AppraisalComment> modelBuilder)
        {
            modelBuilder
                .HasOne(e => e.Recipient)
                .WithMany(e => e.ReceivedAppraisalComments)
                .HasForeignKey(e => e.RecipientId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder
                .HasOne(e => e.Sender)
                .WithMany(e => e.SentAppraisalComments)
                .HasForeignKey(e => e.SenderId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
