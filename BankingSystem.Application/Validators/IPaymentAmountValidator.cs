using BankingSystem.Application.Common.Requests;
using BankingSystem.Application.Common.Responses;
using BankingSystem.Domain.Entities;
using OneOf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Application.Validators
{
    public interface IPaymentAmountValidator 
    {
        OneOf<bool, BankingSystemErrorResponse> AmountIsValid(CreatePaymentRequest paymentRequest, IPaymentMethod paymentMethod);
    }
}
