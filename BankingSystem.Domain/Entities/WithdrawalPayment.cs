using BankingSystem.Domain.Enums;
using OneOf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Domain.Entities
{
    public class WithdrawalPayment : IPaymentMethod
    {
        private const double WithdrawalPercentage = 0.9;
        private const double MinAccountBalance = 100;
        public PaymentTypeEnum PaymentType => PaymentTypeEnum.Withdrawal;

        public Payment CreatePayment(double amount, PaymentAccount paymentAccount)
        {
            return new Payment(Guid.NewGuid(), -amount, DateTime.UtcNow, PaymentTypeEnum.Withdrawal, paymentAccount);
        }

        public OneOf<bool,string> ValidAmount(double transactionAmount, double currentBalance)
        {
           if(!AmountIsAvailable(transactionAmount, currentBalance))
               return $"Transaction not allowed. Your current account balance is {currentBalance}";
           if(!AccountBalanceLeastMin(transactionAmount, currentBalance))
               return $"Transaction not allowed. You must have at least {MinAccountBalance} available at any time!";
            if(!AmountIsLessThenMaxAllowed(transactionAmount, currentBalance))
                return $"Withdrawal amount is more then the allowed procent of {WithdrawalPercentage * 100} %";
            return true;
        }

        private bool AccountBalanceLeastMin(double transactionAmount, double currentBalance)
        {
            return currentBalance - transactionAmount > MinAccountBalance;
        }
        private bool AmountIsAvailable(double transactionAmount, double currentBalance)
        {
            return transactionAmount <= currentBalance;
        }

        private bool AmountIsLessThenMaxAllowed(double transactionAmount, double currentBalance)
        {
            return transactionAmount <= currentBalance * WithdrawalPercentage;
        }
    }
}
