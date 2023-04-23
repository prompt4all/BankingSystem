using BankingSystem.Application.Common.Interfaces.Persistance;
using BankingSystem.Application.Common.Interfaces.Persitance;
using BankingSystem.Application.Common.Interfaces.Services;
using BankingSystem.Application.Common.Requests;
using BankingSystem.Application.Common.Responses;
using BankingSystem.Application.Helpers;
using BankingSystem.Domain.Entities;
using OneOf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Application.Services
{
    public class PaymentAccountService : IPaymentAccountService
    {
        private readonly IPaymentAccountRepository _paymentAccountRepository;
        public PaymentAccountService(IPaymentAccountRepository paymentAccountRepository)
        {
           _paymentAccountRepository = paymentAccountRepository;
        }
        public CreatedPaymentAccountResponse CreatePaymentAccount(CreatePaymentAccountRequest createPaymentAccountRequest, User user) 
        {
            // validate
            // AccountNumber must be unique 
            var paymentAccounts = _paymentAccountRepository.GetPaymentAccountsByAccountNumber(createPaymentAccountRequest.AccountNumber);
            if(paymentAccounts.Any())
            {
                throw new Exception("AccountNumber must ne unique!");
            }
            //create 
            var paymentAccount = new PaymentAccount()
            {
                AccountNumber = createPaymentAccountRequest.AccountNumber,
                Id = Guid.NewGuid(),
                User = user 
            };

            _paymentAccountRepository.Add(paymentAccount);

            return new CreatedPaymentAccountResponse(paymentAccount.AccountNumber, paymentAccount.Id);
        }

        public bool DeletePaymentAccount(DeletePaymentAccountRequest deletePaymentAccountRequest, User user) 
        {
            var paymentAccountToRemove = _paymentAccountRepository.GetPaymentAccountByAccountId(deletePaymentAccountRequest.AccountId, user);
            if (paymentAccountToRemove != null)
            {
                _paymentAccountRepository.Remove(paymentAccountToRemove);
                return true;
            }
            else
            {

                throw new Exception($"Payment account with Id {deletePaymentAccountRequest.AccountId} for user with Id {user.Id} is not found!");
            }

        }

        public GetPaymentAccountsResponse GetPaymentAccountsByUser(User user) 
        {
           return new GetPaymentAccountsResponse( _paymentAccountRepository.GetPaymentAccountsByUser(user.Id).Select(a=>a.ToCreatedPaymentAccountResponse()).ToList()); 
        }
    }
}
