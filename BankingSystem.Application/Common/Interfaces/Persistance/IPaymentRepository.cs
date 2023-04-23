using BankingSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Application.Common.Interfaces.Persistance
{
    public interface IPaymentRepository
    {
        void Add(Payment payment);
        double GetPaymentAccountBalance(PaymentAccount paymentAccount);
    }
}
