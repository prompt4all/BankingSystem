using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Application.Common.Responses
{
    public class BankingSystemErrorResponse
    {
        public IReadOnlyList<string> ErrorMessages { get; init; }
        public int StatusCode { get; init; }
        public BankingSystemErrorResponse(int? errorCode, List<string> errorMessages) 
        {
            ErrorMessages = errorMessages;
            StatusCode = errorCode ?? 500;
        }

    }
}
