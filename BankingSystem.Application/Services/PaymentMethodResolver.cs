using BankingSystem.Application.Common.Interfaces.Services;
using BankingSystem.Domain.Entities;
using BankingSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Application.Services
{
    public class PaymentMethodResolver : IPaymentMethodResolver
    {
        private readonly IEnumerable<IPaymentMethod> _paymentMethods;

        public PaymentMethodResolver(IEnumerable<IPaymentMethod> paymentMethods)
        {
            _paymentMethods = paymentMethods;
        }

        public IPaymentMethod Resolve(PaymentTypeEnum paymentType)
        {
            IPaymentMethod paymentMethod = _paymentMethods.FirstOrDefault(item => item.PaymentType == paymentType);
            if (paymentMethod == null)
            {
                throw new ArgumentException($"Payment method {paymentType} not found");
            }
            return paymentMethod;
        }
    }
}
