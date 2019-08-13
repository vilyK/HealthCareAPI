namespace HealthCare.BusinessLayer
{
    using System.Linq;
    using DataLayer;
    using Interfaces;

    public class DatabaseService : IDatabaseService
    {
        private HealthCareDbContext _dbContext;

        public DatabaseService(HealthCareDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        //public TEntity RetrieveEntityById<TEntity>(int id) where TEntity : class
        //{
        //   return _dbContext.Set<TEntity>().Where(x => x.Id == id);
        //}
    }

}
