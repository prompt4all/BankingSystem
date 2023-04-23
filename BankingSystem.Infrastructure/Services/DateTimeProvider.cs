using BankingSystem.Application.Common.Interfaces.Services;

namespace BankingSystem.Infrastructure.Services;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}