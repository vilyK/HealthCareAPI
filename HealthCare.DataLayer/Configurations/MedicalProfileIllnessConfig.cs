namespace HealthCare.DataLayer.Configurations
{
    using Entities.MedicalData;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class MedicalProfileIllnessConfig : IEntityTypeConfiguration<MedicalProfileIllness>
    {
        public void Configure(EntityTypeBuilder<MedicalProfileIllness> modelBuilder)
        {
            modelBuilder
                .HasOne(e => e.MedicalProfile)
                .WithMany(e => e.MedicalProfileIllnesses)
                .HasForeignKey(e => e.MedicalProfileId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder
                .HasOne(e => e.Illness)
                .WithMany(e => e.MedicalProfileIllnesses)
                .HasForeignKey(e => e.IllnessId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
