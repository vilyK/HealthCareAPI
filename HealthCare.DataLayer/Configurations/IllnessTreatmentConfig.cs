namespace HealthCare.DataLayer.Configurations
{
    using Entities.MedicalData;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class IllnessTreatmentConfig : IEntityTypeConfiguration<IllnessTreatment>
    {
        public void Configure(EntityTypeBuilder<IllnessTreatment> modelBuilder)
        {
            modelBuilder
                .HasOne(e => e.Illness)
                .WithMany(e => e.IllnessTreatments)
                .HasForeignKey(e => e.IllnessId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder
                .HasOne(e => e.Treatment)
                .WithMany(e => e.IllnessTreatments)
                .HasForeignKey(e => e.TreatmentId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
