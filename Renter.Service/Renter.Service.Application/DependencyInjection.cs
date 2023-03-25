using Microsoft.Extensions.DependencyInjection;
using Renter.Service.Application.Services.Authentication;

namespace Renter.Service.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IAuthenticationService, AuthenticationService>();

        return services;
    }
}
