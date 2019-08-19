﻿namespace HealthCare.BusinessLayer.Interfaces
{
    using System.Collections.Generic;

    using HealthCare.Interfaces;
    using Utilities.Enums;

    public interface IContactsService
    {
        void PersistEntity<TRequestObj, TDBObject>(TRequestObj requestEntity, int userContactId, DatabaseOperation operation)
            where TDBObject : class, IIdentity, new()
            where TRequestObj : class;

        void PersistEntities<TRequestObj, TDBObject>(IEnumerable<TRequestObj> requestEntities, int userContactId, DatabaseOperation operation)
            where TDBObject : class, IIdentity, new()
            where TRequestObj : class;

    }
}