namespace HealthCare.DataLayer.Configurations
{
    using Entities.MedicalData;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class MedicalProfileAllergyConfig : IEntityTypeConfiguration<MedicalProfileAllergy>
    {
        public void Configure(EntityTypeBuilder<MedicalProfileAllergy> modelBuilder)
        {
            modelBuilder
                .HasOne(e => e.MedicalProfile)
                .WithMany(e => e.MedicalProfileAllergies)
                .HasForeignKey(e => e.MedicalProfileId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder
                .HasOne(e => e.Allergy)
                .WithMany(e => e.MedicalProfileAllergies)
                .HasForeignKey(e => e.AllergyId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
