using BankingSystem.Application.Common.Interfaces.Services;
using BankingSystem.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BankingSystem.Api.Controllers
{
    public abstract class CustomApiController : ControllerBase
    {
        public readonly IUserService UserService;
        public User BaseUser { get; set; }

        public CustomApiController(IUserService userService) : base()
        {
            UserService = userService;
        }
    }
}
