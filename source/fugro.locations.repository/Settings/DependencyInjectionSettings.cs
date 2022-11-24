using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace Fugro.Locations.Storage.Settings
{
    public static class DependencyInjectionSettings
    {
        public static void SetupDatabase(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IDatabase, Database>();
            serviceCollection.AddTransient<IInMemoryLocationRepository, InMemoryLocationRepository>();
        }
    }
}
