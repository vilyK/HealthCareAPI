namespace HealthCare.DataLayer.Configurations
{
    using Entities.MedicalCenter;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class MedicalCenterDoctorConfig : IEntityTypeConfiguration<MedicalCenterDoctor>
    {
        public void Configure(EntityTypeBuilder<MedicalCenterDoctor> modelBuilder)
        {
            modelBuilder
                .HasOne(e => e.MedicalCenter)
                .WithMany(e => e.MedicalCenterEmployees)
                .HasForeignKey(e => e.MedicalCenterId);

            modelBuilder
                .HasOne(e => e.Doctor)
                .WithMany(e => e.DoctorWorkPlaces)
                .HasForeignKey(e => e.DoctorId);
        }
    }
}
