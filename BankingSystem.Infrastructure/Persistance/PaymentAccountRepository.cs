using BankingSystem.Application.Common.Interfaces.Persistance;
using BankingSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Infrastructure.Persistance
{
    public class PaymentAccountRepository : IPaymentAccountRepository
    {
        private static readonly List<PaymentAccount> _paymentAccounts = new List<PaymentAccount>();

        public void Add(PaymentAccount paymentAccount)
        {
            _paymentAccounts.Add(paymentAccount);
        }

        public void Remove(PaymentAccount paymentAccount)
        {
            _paymentAccounts.Remove(paymentAccount);
        }

        public PaymentAccount GetPaymentAccountByAccountId(Guid accountId, User user)
        {
           return _paymentAccounts.Where(account => account.User.Id == user.Id && account.Id == accountId).SingleOrDefault();
        }

        public List<PaymentAccount> GetPaymentAccountsByUser(Guid userId)
        {
            return  _paymentAccounts.Where(account => account.User.Id == userId).ToList();
        }

        public List<PaymentAccount> GetPaymentAccountsByAccountNumber(string accountNumber)
        {
            return  _paymentAccounts.Where(account => account.AccountNumber == accountNumber).ToList();
        }
    }
}
