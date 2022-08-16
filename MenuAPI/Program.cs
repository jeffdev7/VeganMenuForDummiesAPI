using Application.AutoMapper;
using Application.Interfaces.Services;
using Application.Services;
using Domain.Interfaces.Repositories;
using Infrastructure.DBConfiguration;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var connection = builder.Configuration.GetConnectionString("MySQlConnectionString");

builder.Services.AddDbContext<ApplicationContext>(options => options.UseMySql(connection, 
    new MySqlServerVersion(new Version(8, 0, 29))));
builder.Services.AddAutoMapper(typeof(DomainViewModelMapping), typeof(ViewModelDomainMapping));

//IoC
    //Repos
    builder.Services.AddScoped<IFoodRepository, FoodRepository>();
    //services
    builder.Services.AddScoped<IFoodServices, FoodServices>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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