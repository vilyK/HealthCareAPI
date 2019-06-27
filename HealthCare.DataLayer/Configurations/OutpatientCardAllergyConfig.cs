namespace HealthCare.DataLayer.Configurations
{
    using Entities.MedicalData;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class OutpatientCardAllergyConfig : IEntityTypeConfiguration<OutpatientCardAllergy>
    {
        public void Configure(EntityTypeBuilder<OutpatientCardAllergy> modelBuilder)
        {
            modelBuilder
                .HasOne(e => e.OutpatientCard)
                .WithMany(e => e.OutpatientCardAllergies)
                .HasForeignKey(e => e.OutpatientCardId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder
                .HasOne(e => e.Allergy)
                .WithMany(e => e.OutpatientCardAllergies)
                .HasForeignKey(e => e.AllergyId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
