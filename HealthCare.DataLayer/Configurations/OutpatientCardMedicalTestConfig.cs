namespace HealthCare.DataLayer.Configurations
{
    using Entities.MedicalData;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class OutpatientCardMedicalTestConfig : IEntityTypeConfiguration<OutpatientCardMedicalTest>
    {
        public void Configure(EntityTypeBuilder<OutpatientCardMedicalTest> modelBuilder)
        {
            modelBuilder
                .HasOne(e => e.OutpatientCard)
                .WithMany(e => e.OutpatientCardMedicalTests)
                .HasForeignKey(e => e.OutpatientCardId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder
                .HasOne(e => e.MedicalTest)
                .WithMany(e => e.OutpatientCardMedicalTests)
                .HasForeignKey(e => e.MedicalTestId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
