namespace HealthCare.DataLayer.Configurations
{
    using Entities.Pharmacy;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class PharmacyDistributorConfig : IEntityTypeConfiguration<PharmacyDistributor>
    {
        public void Configure(EntityTypeBuilder<PharmacyDistributor> modelBuilder)
        {
            modelBuilder
                .HasOne(e => e.Distributor)
                .WithMany(e => e.PharmaciesPerDistributor)
                .HasForeignKey(e => e.DistributorId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder
                .HasOne(e => e.Pharmacy)
                .WithMany(e => e.DistributorsPerPharmacy)
                .HasForeignKey(e => e.PharmacyId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
