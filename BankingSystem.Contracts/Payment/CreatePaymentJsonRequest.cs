using BankingSystem.Contracts.PaymentAccount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Contracts.Payment
{
    public class CreatePaymentJsonRequest
    {
        public double  Amount { get; set; }
        public int PaymentType { get; set; }
        public PaymentAccountJson PaymentAccount { get;set; }

    }
}
