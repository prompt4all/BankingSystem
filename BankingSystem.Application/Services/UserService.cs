using BankingSystem.Application.Common.Interfaces.Persitance;
using BankingSystem.Application.Common.Interfaces.Services;
using BankingSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User GetUser(Guid userId)
        {
            return _userRepository.GetUserById(userId);
        }
    }
}
