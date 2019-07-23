namespace HealthCare.DataLayer.Configurations
{
    using Entities.MedicalMan;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class MedicalMenSpecialtyConfig : IEntityTypeConfiguration<MedicalMenSpecialty>
    {
        public void Configure(EntityTypeBuilder<MedicalMenSpecialty> modelBuilder)
        {
            modelBuilder
                .HasOne(e => e.MedManInfo)
                .WithMany(e => e.Specialties)
                .HasForeignKey(e => e.MedMenInfoId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder
                .HasOne(e => e.Specialty)
                .WithMany(e => e.MedicalMan)
                .HasForeignKey(e => e.SpecialtyId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
