using Microsoft.Extensions.DependencyInjection;
using BankingSystem.Application.Common.Interfaces;
using BankingSystem.Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using BankingSystem.Application.Common.Interfaces.Persitance;
using BankingSystem.Infrastructure.Persitance;
using BankingSystem.Application.Common.Interfaces.Persistance;
using BankingSystem.Infrastructure.Persistance;

namespace BankingSystem.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services,
    Microsoft.Extensions.Configuration.IConfiguration configuration)
    {
     
        services.AddSingleton<BankingSystem.Application.Common.Interfaces.Services.IDateTimeProvider, DateTimeProvider>();

        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IPaymentAccountRepository, PaymentAccountRepository>();
        services.AddScoped<IPaymentRepository, PaymentRepository>();
        return services;
    }
}