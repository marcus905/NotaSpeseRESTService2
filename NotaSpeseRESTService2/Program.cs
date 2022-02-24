using Microsoft.EntityFrameworkCore;
using NotaSpeseRESTService2.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<NotaSpeseDbContext>(options => options.UseInMemoryDatabase("NSDBctx"));

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
