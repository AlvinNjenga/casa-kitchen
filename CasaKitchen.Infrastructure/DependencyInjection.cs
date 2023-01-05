using CasaKitchen.Application.Common.Interfaces.Authentication;
using CasaKitchen.Application.Common.Interfaces.Persistence;
using CasaKitchen.Application.Common.Interfaces.Services;
using CasaKitchen.Infrastructure.Authentication;
using CasaKitchen.Infrastructure.Persistence;
using CasaKitchen.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CasaKitchen.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        Microsoft.Extensions.Configuration.ConfigurationManager configuration)
    {
        services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));
        services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
        services.AddSingleton<IDateTimeProvider, DateTimeProvider>();

        services.AddScoped<IUserRepository, UserRepository>();

        return services;
    }
}
