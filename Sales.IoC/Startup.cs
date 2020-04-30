using Microsoft.Extensions.DependencyInjection;

namespace Sales.IoC
{
    public static class Startup
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection serviceCollection)
        {
            return serviceCollection;
        }
    }
}
