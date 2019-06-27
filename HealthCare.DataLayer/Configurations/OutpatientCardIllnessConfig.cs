namespace HealthCare.DataLayer.Configurations
{
    using Entities.MedicalData;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class OutpatientCardIllnessConfig : IEntityTypeConfiguration<OutpatientCardIllness>
    {
        public void Configure(EntityTypeBuilder<OutpatientCardIllness> modelBuilder)
        {
            modelBuilder
                .HasOne(e => e.OutpatientCard)
                .WithMany(e => e.OutpatientCardIllnesses)
                .HasForeignKey(e => e.OutpatientCardId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder
                .HasOne(e => e.Illness)
                .WithMany(e => e.OutpatientCardIllnesses)
                .HasForeignKey(e => e.IllnessId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
