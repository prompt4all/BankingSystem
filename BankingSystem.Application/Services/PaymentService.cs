using BankingSystem.Application.Common.Interfaces.Persistance;
using BankingSystem.Application.Common.Interfaces.Services;
using BankingSystem.Application.Common.Requests;
using BankingSystem.Application.Validators;
using BankingSystem.Domain.Entities;
using BankingSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Application.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly IPaymentRepository _paymentRepository;
        private readonly IPaymentMethodResolver _paymentMethodResolver;
        private readonly IPaymentAmountValidator _paymentAmountValidator;

        public PaymentService(IPaymentRepository paymentRepository, IPaymentMethodResolver paymentMethodResolver, IPaymentAmountValidator paymentAmountValidator)
        {
            _paymentRepository = paymentRepository;
            _paymentMethodResolver = paymentMethodResolver;
            _paymentAmountValidator = paymentAmountValidator;
        }
        public void CreatePayment(CreatePaymentRequest createPaymentRequest)
        {
            var paymentMethod = _paymentMethodResolver.Resolve(createPaymentRequest.PaymentType);
            //validate
            var amountValidationResult = _paymentAmountValidator.AmountIsValid(createPaymentRequest, paymentMethod);
            if (amountValidationResult.IsT0)
            {
                var payment = paymentMethod.CreatePayment(createPaymentRequest.Amount, createPaymentRequest.PaymentAccount);

                _paymentRepository.Add(payment);
            }
            else
            {
                throw new Exception(String.Join(",", amountValidationResult.AsT1.ErrorMessages));
            }
        }
    }
}
