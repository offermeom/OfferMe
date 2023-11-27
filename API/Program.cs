using API.Data;
using API.Services;
using API.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(options => options.AddDefaultPolicy(config => config.WithOrigins("http://localhost:5173").AllowAnyHeader().AllowAnyMethod())); // ** Configure CORS Policy
builder.Services.AddDbContext<OMContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));// ** Configure OMContext with SQL Server
// Add services to the container.
builder.Services.AddScoped<IUserService, UserService>(); // ** Register UserService Implementation
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) app.UseSwagger().UseSwaggerUI();
app.UseCors();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();