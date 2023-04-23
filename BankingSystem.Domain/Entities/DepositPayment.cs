using BankingSystem.Domain.Enums;
using OneOf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Domain.Entities
{
    public class DepositPayment : IPaymentMethod
    {
        private const double MaxDepositAmount = 10000;
        public PaymentTypeEnum PaymentType => PaymentTypeEnum.Deposit;

        public Payment CreatePayment(double amount, PaymentAccount paymentAccount)
        {
            return new Payment(Guid.NewGuid(), amount, DateTime.UtcNow, PaymentTypeEnum.Deposit, paymentAccount);
        }

        public OneOf<bool, string> ValidAmount(double transactionAmount, double currentBalance)
        {
            if (transactionAmount <= MaxDepositAmount)
                return true;
            else
                return $"Deposit amount is more then the allowed amount of {MaxDepositAmount}";
        }
    }
}
