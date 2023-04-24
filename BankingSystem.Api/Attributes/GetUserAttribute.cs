using BankingSystem.Api.Controllers;
using BankingSystem.Domain.Entities;
using Microsoft.AspNetCore.Mvc.Filters;


namespace BankingSystem.Api.Attributes
{
    public class GetUserAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var controller = context.Controller as CustomApiController;
           
            if (context.HttpContext.Request.Headers.TryGetValue("UserId", out var userIdValues) && userIdValues.Any())
            {
                controller.BaseUser = controller.UserService.GetUser(new Guid(userIdValues.Single()));
            }
            else
            {
                throw new Exception($"User is not authenticated");
            }
        }
    }
}
