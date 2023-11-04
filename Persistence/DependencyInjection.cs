using Contracts.Persistence;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Repositories;

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

        services.AddScoped<IRepository<User>, UserRepository>();
        
        return services;
    }
}