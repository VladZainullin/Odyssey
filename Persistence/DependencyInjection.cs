using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Persistence;

public static class DependencyInjection
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services)
    {
        services.AddDbContextPool<AppDbContext>(options =>
        {
            options.UseInMemoryDatabase("AppDatabase");
            options.UseSnakeCaseNamingConvention();
        });
        
        return services;
    }
}