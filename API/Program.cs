using API.Data;
using API.Services;
using API.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddLogging(options => {
    options.AddConsole();
    options.SetMinimumLevel(LogLevel.Debug);
    options.AddDebug();
}); // ** Configure Logging Service
builder.Services.AddCors(options => options.AddDefaultPolicy(config => config.WithOrigins("http://localhost:5173").AllowAnyHeader().AllowAnyMethod()));
builder.Services.AddDbContext<OMContext>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
    options.UseLoggerFactory(LoggerFactory.Create(config => {
        config.AddConsole();
        config.AddDebug();
    }));
});// ** Configure OMContext with SQL Server and logging
// Add services to the container.
builder.Services.AddScoped<IUserService, UserService>(); // ** Register UserService Implementation
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
    app.UseSwagger().UseSwaggerUI();
app.UseCors();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();