namespace HealthCare.DataLayer.Configurations
{
    using Entities.PharmacyCompany;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class PharmacyCompanyTypeConfig : IEntityTypeConfiguration<PharmacyCompanyType>
    {
        public void Configure(EntityTypeBuilder<PharmacyCompanyType> modelBuilder)
        {
            modelBuilder
                .HasOne(e => e.PharmacyCompanyInfo)
                .WithMany(e => e.PharmacyCompanyTypes)
                .HasForeignKey(e => e.PharmacyCompanyInfoId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder
                .HasOne(e => e.CompanyType)
                .WithMany(e => e.PharmacyCompanyTypes)
                .HasForeignKey(e => e.CompanyTypeId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
