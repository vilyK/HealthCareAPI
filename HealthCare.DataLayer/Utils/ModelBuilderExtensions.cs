namespace HealthCare.DataLayer.Utils
{
    using Microsoft.EntityFrameworkCore;

    using Entities.MedicalData;
    using Entities.MedicalMan;
    using Entities.User;
    using Interfaces;

    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder, IDataRetriever dataRetriever)
        {
            modelBuilder.Entity<Area>().HasData(dataRetriever.GetData<Area>());

            modelBuilder.Entity<AllergyType>().HasData(dataRetriever.GetData<AllergyType>());

            modelBuilder.Entity<City>().HasData(dataRetriever.GetData<City>());

            modelBuilder.Entity<Country>().HasData(dataRetriever.GetData<Country>());

            modelBuilder.Entity<IllnessCategory>().HasData(dataRetriever.GetData<IllnessCategory>());

            modelBuilder.Entity<IllnessType>().HasData(dataRetriever.GetData<IllnessType>());

            modelBuilder.Entity<Medicament>().HasData(dataRetriever.GetData<Medicament>());

            modelBuilder.Entity<MedicamentCategory>().HasData(dataRetriever.GetData<MedicamentCategory>());

            modelBuilder.Entity<Specialty>().HasData(dataRetriever.GetData<Specialty>());
        }
    }
}
