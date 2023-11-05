using Microsoft.OpenApi.Models;

namespace Web;

public static class DependencyInjection
{
    public static IServiceCollection AddWebApiServices(this IServiceCollection services)
    {
        services.AddControllers();
        
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen(x =>
        {
            var security = new OpenApiSecurityRequirement
            {
                [new OpenApiSecurityScheme
                {
                    Scheme = "Bearer"
                }] = Array.Empty<string>(),
            };
            
            x.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
            {
                Description = "JWT Authorization header using the bearer scheme",
                Name = "Authorization",
                In = ParameterLocation.Header,
                Type = SecuritySchemeType.ApiKey
            });
            
            x.AddSecurityRequirement(security);
        });

        return services;
    }
}