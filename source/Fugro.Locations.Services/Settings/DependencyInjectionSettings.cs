using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace Fugro.Locations.Services.Settings
{
    public static class DependencyInjectionSettings
    {
        public static void SetupBusinessServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<ILocationService, LocationService>();
        }
    }
}
