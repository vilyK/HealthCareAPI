namespace HealthCare.DataLayer.Configurations
{
    using Entities.MedicalCenter;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class MedicalCenterDepartmentConfig : IEntityTypeConfiguration<MedicalCenterDepartment>
    {
        public void Configure(EntityTypeBuilder<MedicalCenterDepartment> modelBuilder)
        {
            modelBuilder
                .HasOne(e => e.MedicalCenter)
                .WithMany(e => e.MedicalCenterDepartments)
                .HasForeignKey(e => e.MedicalCenterId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder
                .HasOne(e => e.Department)
                .WithMany(e => e.MedicalCenterDepartments)
                .HasForeignKey(e => e.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
