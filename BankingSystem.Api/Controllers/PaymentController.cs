using AutoMapper;
using BankingSystem.Application.Common.Interfaces.Services;
using BankingSystem.Application.Common.Requests;
using BankingSystem.Contracts.Payment;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BankingSystem.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : CustomApiController
    {
        private readonly IMapper _mapper;
        private readonly IPaymentService _paymentService;
       
        public PaymentController(IUserService userService, IPaymentService paymentService, IMapper mapper): base(userService)
        {
            _paymentService = paymentService;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult CreatePayment([FromBody] CreatePaymentJsonRequest request)
        {
            _paymentService.CreatePayment(_mapper.Map<CreatePaymentJsonRequest, CreatePaymentRequest>(request));
            return Ok();
        }
    }
}
