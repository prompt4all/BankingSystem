using BankingSystem.Domain.Enums;
using OneOf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Domain.Entities
{
    public interface IPaymentMethod
    {
        PaymentTypeEnum PaymentType { get; }
        Payment CreatePayment(double amount, PaymentAccount paymentAccount);
        OneOf<bool, string> ValidAmount(double transactionAmount, double currentBalance);
    }
}
