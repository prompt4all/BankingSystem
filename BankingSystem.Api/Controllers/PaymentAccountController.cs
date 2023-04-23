using AutoMapper;
using BankingSystem.Api.Attributes;
using BankingSystem.Application.Common.Interfaces.Services;
using BankingSystem.Application.Common.Requests;
using BankingSystem.Contracts.PaymentAccount;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BankingSystem.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentAccountController : CustomApiController
    {
        private readonly IMapper _mapper;
        private readonly IPaymentAccountService _paymentAccountService;
        public PaymentAccountController(IUserService userService, IMapper mapper, IPaymentAccountService paymentAccountService) : base(userService)
        {
            _mapper = mapper;
            _paymentAccountService = paymentAccountService;
        }

        [HttpPost]
        public IActionResult CreatePaymentAccount([FromBody] CreatePaymentAccountJsonRequest request)
        {
            var response = _paymentAccountService.CreatePaymentAccount(_mapper.Map<CreatePaymentAccountJsonRequest, CreatePaymentAccountRequest>(request), BaseUser);
            return Ok(response);
        }

        [HttpDelete]
        public IActionResult DeletePaymentAccount([FromBody] DeletePaymentAccountJsonRequest request)
        {
            _paymentAccountService.DeletePaymentAccount(_mapper.Map<DeletePaymentAccountJsonRequest, DeletePaymentAccountRequest>(request), BaseUser);
            return Ok();
        }

        [HttpGet]
        public IActionResult GetPaymentAccounts()
        {
             var accounts = _paymentAccountService.GetPaymentAccountsByUser(BaseUser);
             return Ok(accounts);
        }
    }
}
