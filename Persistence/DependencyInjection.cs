using Contracts.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Persistence;

public static class DependencyInjection
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services)
    {
        services.AddDbContextPool<AppDbContext>(options =>
        {
            options.UseSqlite("Filename=App.db");
            options.UseSnakeCaseNamingConvention();
        });

        services.AddScoped<DbContext, AppDbContext>();

        services.AddScoped<IAppDbContext, AppDbContextAdapter>();
        
        return services;
    }
}