using BankingSystem.Application.Common.Responses;
using BankingSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Application.Helpers
{
    public static class PaymentAccountExtension
    {
        public static CreatedPaymentAccountResponse ToCreatedPaymentAccountResponse(this PaymentAccount paymentAccount)
        {
            return new CreatedPaymentAccountResponse(paymentAccount.AccountNumber, paymentAccount.Id);
        }
    }
}
