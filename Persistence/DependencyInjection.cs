using Contracts.Persistence;
using Domain.Entities;
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

        services.AddScoped<DbContext, AppDbContext>();

        services.AddScoped<IRepository<User>, Repository<User>>();
        
        return services;
    }
}