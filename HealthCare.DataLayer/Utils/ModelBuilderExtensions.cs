namespace HealthCare.DataLayer.Utils
{
    using Entities.MedicalCenter;
    using Microsoft.EntityFrameworkCore;

    using Entities.MedicalData;
    using Entities.MedicalMan;
    using Entities.UserAccount;
    using Interfaces;

    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder, IDataRetriever dataRetriever)
        {
            modelBuilder.Entity<Area>().HasData(dataRetriever.RetrieveData<Area>());

            modelBuilder.Entity<AllergyType>().HasData(dataRetriever.RetrieveData<AllergyType>());

            modelBuilder.Entity<City>().HasData(dataRetriever.RetrieveData<City>());

            modelBuilder.Entity<Country>().HasData(dataRetriever.RetrieveData<Country>());

            modelBuilder.Entity<IllnessCategory>().HasData(dataRetriever.RetrieveData<IllnessCategory>());

            modelBuilder.Entity<IllnessType>().HasData(dataRetriever.RetrieveData<IllnessType>());

            modelBuilder.Entity<Medicament>().HasData(dataRetriever.RetrieveData<Medicament>());

            modelBuilder.Entity<MedicamentCategory>().HasData(dataRetriever.RetrieveData<MedicamentCategory>());

            modelBuilder.Entity<Specialty>().HasData(dataRetriever.RetrieveData<Specialty>());

            modelBuilder.Entity<Department>().HasData(dataRetriever.RetrieveData<Department>());

            modelBuilder.Entity<MedicalTestType>().HasData(dataRetriever.RetrieveData<MedicalTestType>());
        }
    }
}
