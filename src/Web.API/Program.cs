using Application;
using Carter;
using Infrastructure;
using Microsoft.AspNetCore.Builder;
using Web.API;

var builder = WebApplication.CreateBuilder(args);
builder.Services
       .AddPresentation()
       .AddApplication()
       .AddInfrastructure(builder.Configuration);

var app = builder.Build();
app.MapCarter();
app.Run();
