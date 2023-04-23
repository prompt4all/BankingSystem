using BankingSystem.Domain.Entities;

namespace BankingSystem.Application.Common.Interfaces.Persitance;

public interface IUserRepository
{
    User? GetUserById(Guid userId);
}