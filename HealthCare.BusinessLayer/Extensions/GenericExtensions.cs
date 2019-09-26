namespace HealthCare.BusinessLayer.Extensions
{
    using System;
    using Microsoft.EntityFrameworkCore;

    using DataLayer.Entities.Base;
    using HealthCare.Interfaces;
    using Utilities.Enums;

    public static class GenericExtensions
    {
        public static int PersistModel<TModel>(this DbContext dbContext, TModel model, DatabaseOperation operation)
            where TModel : SystemData
        {
            switch (operation)
            {
                case DatabaseOperation.Update:
                    {
                        model.UpdateDate = DateTime.Now;

                        dbContext.Entry(model).State = EntityState.Modified;
                        break;
                    }

                case DatabaseOperation.Insert:
                    {
                        dbContext.Entry(model).State = EntityState.Added;
                        break;
                    }
            }

            return model.Id;
        }

        public static void CreateInfoObject<TModel>(this DbContext dbContext, string name, int userId)
            where TModel : IInformation, new()
        {
            var infoModel = new TModel
            {
                Name = name,
                UserId = userId
            };

            dbContext.Add(infoModel);
        }

        public static DatabaseOperation GetDbOperation(this int modelId)
        {
            return modelId == 0 ? DatabaseOperation.Insert : DatabaseOperation.Update;
        }
    }
}
