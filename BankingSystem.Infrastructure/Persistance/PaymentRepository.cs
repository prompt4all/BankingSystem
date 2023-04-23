using BankingSystem.Application.Common.Interfaces.Persistance;
using BankingSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Infrastructure.Persistance
{
    public class PaymentRepository : IPaymentRepository
    {
        private static readonly List<Payment> _payments = new List<Payment>();

        public void Add(Payment payment)
        {
            _payments.Add(payment);
        }

        public double GetPaymentAccountBalance(PaymentAccount paymentAccount) 
        {
            return _payments.Where(p => p.PaymentAccount.Id == paymentAccount.Id).Sum(p => p.Amount);
        }
    }
}
