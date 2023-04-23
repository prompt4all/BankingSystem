using BankingSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Application.Common.Interfaces.Services
{
    public interface IUserService
    {
        User GetUser(Guid userId);
    }
}
