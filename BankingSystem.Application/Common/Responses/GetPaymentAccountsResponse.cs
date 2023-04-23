using BankingSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Application.Common.Responses
{
    public class GetPaymentAccountsResponse
    {
        public GetPaymentAccountsResponse(List<CreatedPaymentAccountResponse> paymentAccounts)
        {
            PaymentAccounts = paymentAccounts;
        }
        public List<CreatedPaymentAccountResponse> PaymentAccounts { get; init; }
    }
}
