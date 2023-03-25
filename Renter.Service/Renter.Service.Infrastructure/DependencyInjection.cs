using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Renter.Service.Application.Common.Interfaces.Authentication;
using Renter.Service.Application.Common.Interfaces.Services;
using Renter.Service.Infrastructure.Authentication;
using Renter.Service.Infrastructure.Services;

namespace Renter.Service.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, ConfigurationManager configuration)
    {
        services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));

        services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
        services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
        
        return services;
    }
}
