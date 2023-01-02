using CasaKitchen.Application.Services;
using CasaKitchen.Application.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace CasaKitchen.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IAuthenticationService, AuthenticationService>();
        return services;
    }
}
