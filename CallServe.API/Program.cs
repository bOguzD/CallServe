using CallServe.Core.Repositories.Contracts;
using CallServe.Core.UnitOfWorks;
using CallServe.Core;
using CallServe.Service.Service.Contracts;
using CallServe.Service.Service;
using CallServe.Service.Services.EntityServices.Contracts;
using CallServe.Service.Services.EntityServices;
using CallServe.Core.Repositories;

var builder = WebApplication.CreateBuilder(args);

var configuration = builder.Configuration;
var services = builder.Services;

//services.AddDependencyResolvers(configuration);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

services.AddMemoryCache();

services.AddDbContext<CallServeContext>();
services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
services.AddScoped(typeof(IService<>), typeof(Service<>));
services.AddScoped<IUnitOfWork, UnitOfWork>();

services.AddTransient<IProductService, ProductService>();





var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
