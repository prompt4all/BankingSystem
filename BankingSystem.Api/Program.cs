using AutoMapper;
using BankingSystem.Api.Attributes;
using BankingSystem.Api.Middleware;
using BankingSystem.Application;
using BankingSystem.Contracts.Mapper;
using BankingSystem.Contracts.Payment;
using BankingSystem.Infrastructure;
using FluentValidation;

var builder = WebApplication.CreateBuilder(args);
{
    // Add services to the container.
    builder.Services.AddApplication()
                    .AddInfrastructure(builder.Configuration);

    // Auto Mapper Configurations
     var mapperConfig = new MapperConfiguration(mc =>
     {
         mc.AddProfile(new MapProfile());
     });

     IMapper mapper = mapperConfig.CreateMapper();
     builder.Services.AddSingleton(mapper);
     builder.Services.AddControllers( c=> c.Filters.Add<GetUserAttribute>());
     builder.Services.AddValidatorsFromAssemblyContaining<Program>();
}
var app = builder.Build();
{
    app.UseMiddleware<ErrorHandlingMiddleware>();
    app.UseHttpsRedirection();
    app.UseAuthorization();
    app.MapControllers();
    app.Run();
}
