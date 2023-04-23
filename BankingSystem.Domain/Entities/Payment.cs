using BankingSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Domain.Entities
{
    public  class Payment
    {
        public Guid Id { get; init; }
        public double Amount { get; init; }
        public DateTime CreatedDate { get; init; }

        public PaymentTypeEnum PaymentType { get; init; }

        public PaymentAccount PaymentAccount { get; init; } = new PaymentAccount();

        public Payment(Guid id, double amount, DateTime createdDate, PaymentTypeEnum paymentType, PaymentAccount paymentAccount)
        {
            Id = id;
            Amount = amount;
            CreatedDate = createdDate;
            PaymentType = paymentType;
            PaymentAccount = paymentAccount;
        }
    }
}
