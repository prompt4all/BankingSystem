using BankingSystem.Domain.Entities;
using BankingSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Application.Common.Requests
{
    public class CreatePaymentRequest
    {
        public double Amount { get; set; }
        public PaymentTypeEnum PaymentType { get; set; }
        public PaymentAccount PaymentAccount { get; set; }
    }
}
