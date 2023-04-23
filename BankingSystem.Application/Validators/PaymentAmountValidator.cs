using BankingSystem.Application.Common.Interfaces.Persistance;
using BankingSystem.Application.Common.Requests;
using BankingSystem.Application.Common.Responses;
using BankingSystem.Domain.Entities;
using OneOf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Application.Validators
{
    public class PaymentAmountValidator : IPaymentAmountValidator
    {
        private readonly IPaymentRepository _paymentRepository;

        public PaymentAmountValidator(IPaymentRepository paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }
        public OneOf<bool,BankingSystemErrorResponse> AmountIsValid(CreatePaymentRequest paymentRequest, IPaymentMethod paymentMethod)
        {
            var currentBalance = _paymentRepository.GetPaymentAccountBalance(paymentRequest.PaymentAccount);
            var validationResult =  paymentMethod.ValidAmount(paymentRequest.Amount, currentBalance);
            if (validationResult.IsT1 && !String.IsNullOrEmpty(validationResult.AsT1))
                return new BankingSystemErrorResponse((int)HttpStatusCode.BadRequest, new List<string>() { validationResult.AsT1 });
            else
                return validationResult.AsT0;
        }
    }
}
