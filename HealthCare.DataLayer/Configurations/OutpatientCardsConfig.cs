namespace HealthCare.DataLayer.Configurations
{
    using Entities.MedicalData;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class OutpatientCardConfig : IEntityTypeConfiguration<OutpatientCard>
    {
        public void Configure(EntityTypeBuilder<OutpatientCard> modelBuilder)
        {
            modelBuilder
                .HasOne(e => e.Doctor)
                .WithMany(e => e.DoctorsOutpatientCards)
                .HasForeignKey(e => e.DoctorId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
