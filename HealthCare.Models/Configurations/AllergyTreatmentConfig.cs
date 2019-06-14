namespace HealthCare.DataLayer.Configurations
{
    using Entities.MedicalData;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class AllergyTreatmentConfig : IEntityTypeConfiguration<AllergyTreatment>
    {
        public void Configure(EntityTypeBuilder<AllergyTreatment> modelBuilder)
        {
            modelBuilder.HasKey(e => new {e.AllergyId, e.TreatmentId});

            modelBuilder
                .HasOne(e => e.Allergy)
                .WithMany(e => e.AllergyTreatments)
                .HasForeignKey(e => e.AllergyId);

            modelBuilder
                .HasOne(e => e.Treatment)
                .WithMany(e => e.AllergyTreatments)
                .HasForeignKey(e => e.TreatmentId);
        }
    }
}
