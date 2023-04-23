using BankingSystem.Application.Common.Requests;
using BankingSystem.Application.Common.Responses;
using BankingSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Application.Common.Interfaces.Services
{
    public interface IPaymentAccountService
    {
        CreatedPaymentAccountResponse CreatePaymentAccount(CreatePaymentAccountRequest createPaymentAccountRequest, User user);
        GetPaymentAccountsResponse GetPaymentAccountsByUser(User user);
        bool DeletePaymentAccount(DeletePaymentAccountRequest deletePaymentAccountRequest, User user);
    }
}
