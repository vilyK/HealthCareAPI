namespace HealthCare.DataLayer.Configurations
{
    using Entities.MedicalData;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class TreatmentMedicamentConfig : IEntityTypeConfiguration<TreatmentMedicament>
    {
        public void Configure(EntityTypeBuilder<TreatmentMedicament> modelBuilder)
        {
            modelBuilder
                .HasOne(e => e.Treatment)
                .WithMany(e => e.TreatmentMedicaments)
                .HasForeignKey(e => e.TreatmentId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder
                .HasOne(e => e.Medicament)
                .WithMany(e => e.TreatmentMedicaments)
                .HasForeignKey(e => e.MedicamentId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
