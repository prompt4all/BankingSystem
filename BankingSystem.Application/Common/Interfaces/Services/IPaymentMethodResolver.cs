using BankingSystem.Domain.Entities;
using BankingSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Application.Common.Interfaces.Services
{
    public interface IPaymentMethodResolver
    {
        IPaymentMethod Resolve(PaymentTypeEnum paymentType);
    }
}
