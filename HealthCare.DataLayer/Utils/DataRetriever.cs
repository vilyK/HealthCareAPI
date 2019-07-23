namespace HealthCare.DataLayer.Utils
{
    using System.Collections.Generic;
    using System.IO;
    using Microsoft.Extensions.Options;
    using Newtonsoft.Json;

    using Contracts.Configuration;
    using Interfaces;

    public class DataRetriever : IDataRetriever, IDependencyInjection
    {
        private readonly IOptionsSnapshot<SeedSettings> _seedSettings;
        
        public DataRetriever(IOptionsSnapshot<SeedSettings> seedSettings)
        {
            _seedSettings = seedSettings;
        }

        public List<TEntity> GetData<TEntity>() where TEntity : class
        {
            var path = Path.Combine(_seedSettings.Value.BasePath, $"{typeof(TEntity).Name}.json");

            var content = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<List<TEntity>>(content);
        }
    }
}
