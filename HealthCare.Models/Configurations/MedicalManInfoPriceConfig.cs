namespace HealthCare.DataLayer.Configurations
{
    using Entities.MedicalMan;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class MedicalManInfoPriceConfig : IEntityTypeConfiguration<MedicalManInfoPrice>
    {
        public void Configure(EntityTypeBuilder<MedicalManInfoPrice> modelBuilder)
        {
            modelBuilder
                .HasOne(e => e.MedManInfo)
                .WithMany(e => e.Prices)
                .HasForeignKey(e => e.MedManInfoId);

            modelBuilder
                .HasOne(e => e.PriceType)
                .WithMany(e => e.MedicalMen)
                .HasForeignKey(e => e.PriceTypeId);
        }
    }
}
