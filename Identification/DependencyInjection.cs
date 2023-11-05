using System.Text;
using Contracts.Identification;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

namespace Identification;

public static class DependencyInjection
{
    public static IServiceCollection AddIdentificationServicesService(this IServiceCollection services)
    {
        services
            .AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(x =>
            {
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidIssuer = "Issuer",
                    ValidAudience = "",
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("fwefwef")),
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true
                };
            });

        services.AddTransient<IJwtTokenService, JwtTokenService>();

        return services;
    }
}