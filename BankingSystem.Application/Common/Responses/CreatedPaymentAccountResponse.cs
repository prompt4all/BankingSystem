using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Application.Common.Responses
{
    public class CreatedPaymentAccountResponse
    {
        public CreatedPaymentAccountResponse(string accountNumber, Guid id)
        { 
            AccountNumber = accountNumber;
            Id = id;
        }
        public string AccountNumber { get; init; }
        public Guid Id { get; init; }
    }
}
