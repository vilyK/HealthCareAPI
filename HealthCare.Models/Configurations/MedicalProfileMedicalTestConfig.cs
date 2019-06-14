namespace HealthCare.DataLayer.Configurations
{
    using Entities.MedicalData;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class MedicalProfileMedicalTestConfig : IEntityTypeConfiguration<MedicalProfileMedicalTest>
    {
        public void Configure(EntityTypeBuilder<MedicalProfileMedicalTest> modelBuilder)
        {
            modelBuilder
                .HasOne(e => e.MedicalProfile)
                .WithMany(e => e.MedicalProfileMedicalTests)
                .HasForeignKey(e => e.MedicalProfileId);

            modelBuilder
                .HasOne(e => e.MedicalTest)
                .WithMany(e => e.MedicalProfileMedicalTests)
                .HasForeignKey(e => e.MedicalTestId);
        }
    }
}
