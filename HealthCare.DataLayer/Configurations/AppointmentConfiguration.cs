namespace HealthCare.DataLayer.Configurations
{
    using Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class AppointmentConfiguration : IEntityTypeConfiguration<Appointment>
    {
        public void Configure(EntityTypeBuilder<Appointment> modelBuilder)
        {
            modelBuilder
                .HasOne(e => e.Patient)
                .WithMany(e => e.PatientAppointments)
                .HasForeignKey(e => e.PatientId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder
                .HasOne(e => e.Doctor)
                .WithMany(e => e.DoctorAppointments)
                .HasForeignKey(e => e.DoctorId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
