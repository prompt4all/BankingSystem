using BankingSystem.Application.Common.Interfaces.Persistance;
using BankingSystem.Application.Common.Interfaces.Services;
using BankingSystem.Application.Services;
using BankingSystem.Application.Validators;
using BankingSystem.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace BankingSystem.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddTransient<IUserService, UserService>();
        services.AddTransient<IPaymentAccountService, PaymentAccountService>();
        services.AddTransient<IPaymentMethodResolver, PaymentMethodResolver>();
        services.AddTransient<IPaymentService, PaymentService>();
        services.AddTransient<IPaymentMethod, DepositPayment>();
        services.AddTransient<IPaymentMethod, WithdrawalPayment>();
        services.AddScoped<IPaymentAmountValidator, PaymentAmountValidator>();
        return services;
    }
}