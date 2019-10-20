﻿namespace HealthCare.BusinessLayer.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using Microsoft.EntityFrameworkCore;

    using DataLayer.Entities.Base;
    using HealthCare.Interfaces;
    using Utilities.Enums;

    public static class GenericExtensions
    {
        public static IEnumerable<T> EmptyIfNull<T>(this IEnumerable<T> enumerable) => enumerable ?? Enumerable.Empty<T>();

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

        public static void SetDocumentId<TModel>(this TModel model, DocumentType documentType, int documentId)
            where TModel : IMedicalData
        {
            switch (documentType)
            {
                case DocumentType.MedicalProfile:
                    model.MedicalProfileId = documentId;
                    break;
                case DocumentType.OutpatientCard:
                    model.OutpatientCardId = documentId;
                    break;
            }
        }

        public static void DeleteEntity<TModel>(this DbContext dbContext, TModel model)
            where TModel : SystemData
        {
            model.IsDeleted = true;
            dbContext.Entry(model).State = EntityState.Modified;
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

        public static TModel SingleOrNew<TModel>(this IQueryable<TModel> source, Expression<Func<TModel, bool>> predicate)
            where TModel : class, new()
        {
            return source.SingleOrDefault(predicate) ?? new TModel();
        }
    }
}
