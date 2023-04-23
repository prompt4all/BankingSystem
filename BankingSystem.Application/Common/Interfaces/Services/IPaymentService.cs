using BankingSystem.Application.Common.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Application.Common.Interfaces.Services
{
    public interface IPaymentService
    {
        void CreatePayment(CreatePaymentRequest createPaymentRequest);
    }
}
