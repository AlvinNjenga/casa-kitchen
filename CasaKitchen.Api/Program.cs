using CasaKitchen.Application;
using CasaKitchen.Infrastructure;
using CasaKitchen.Api.Filters;

var builder = WebApplication.CreateBuilder(args);
{

    builder.Services
        .AddApplication()
        .AddInfrastructure(builder.Configuration)
        .AddControllers();
}

var app = builder.Build();
{
    app.UseExceptionHandler("/error");

    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}

