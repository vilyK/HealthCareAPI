namespace HealthCare.Interfaces
{
    using System.Collections.Generic;

    public interface IDataRetriever
    {
        List<TEntity> GetData<TEntity>() where TEntity : class;
    }
}
