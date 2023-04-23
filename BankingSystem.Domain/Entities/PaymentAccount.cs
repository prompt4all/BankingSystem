using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Domain.Entities
{
    /// <summary>
    /// Payment Account is a class that respresents a sort of wallet account
    /// </summary>
    public class PaymentAccount
    {
        public Guid Id { get; init; }
        public string AccountNumber { get; init; }
        public User User { get; init; }

    }
}
