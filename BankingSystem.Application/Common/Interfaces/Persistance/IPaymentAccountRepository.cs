using BankingSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Application.Common.Interfaces.Persistance
{
    public interface IPaymentAccountRepository
    {
        void Add(PaymentAccount paymentAccount);
        void Remove(PaymentAccount paymentAccount);
        List<PaymentAccount> GetPaymentAccountsByUser(Guid userId);
        PaymentAccount GetPaymentAccountByAccountId(Guid accountId, User user);
        List<PaymentAccount> GetPaymentAccountsByAccountNumber(string accountNumber);
    }
}
