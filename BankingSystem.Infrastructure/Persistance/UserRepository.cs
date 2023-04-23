using BankingSystem.Application.Common.Interfaces.Persitance;
using BankingSystem.Domain.Entities;

namespace BankingSystem.Infrastructure.Persitance;

public class UserRepository : IUserRepository
{
    private static readonly List<User> _users = new List<User>()
    { 
        new User(){ Id = new Guid("bd97159f-190d-4ad0-bfb9-d08e2abf2853"), FirstName = "Alice", LastName = "Testing", Email ="alice@test.com" },
        new User(){ Id = new Guid("b5005cf3-dd68-4b5e-90e3-86add9d66264"), FirstName = "Bob", LastName="Rader", Email="bob@test.com"},
        new User(){ Id = new Guid("6cd6e321-8530-48c6-bb47-c72bafc8f38d"), FirstName="Vienner", LastName="Schnitzel", Email="vienner@test.com"}
    };
    
    public User GetUserById(Guid userId)
    {
        return _users.SingleOrDefault(u=>u.Id == userId) ?? throw new Exception($"User with Id {userId} is not registered");
    }
}