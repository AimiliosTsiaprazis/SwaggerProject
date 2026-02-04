using System;
using Microsoft.OpenApi.Models;
using Hangfire;
using Hangfire.MemoryStorage;
using Supabase;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllers()
.AddNewtonsoftJson();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSingleton<ICustomerService, CustomerService>();
builder.Services.AddSingleton<IOrderService, OrderService>();
builder.Services.AddSingleton<IProductService, ProductService>();
builder.Services.AddSwaggerGen(swagger =>
{
    swagger.SwaggerDoc("v1", new OpenApiInfo { Title = "SwaggerProject", Version = "v1" });
});
builder.Services.AddHangfire(config => config.UseMemoryStorage());
builder.Services.AddHangfireServer();
var supabaseUrl = Environment.GetEnvironmentVariable("SUPABASE_URL_SWAGGER_PROJECT");
var supabaseKey = Environment.GetEnvironmentVariable("SUPABASE_KEY_SWAGGER_PROJECT");

builder.Services.AddSingleton(svc => new SupabaseService.SupabaseService(supabaseUrl, supabaseKey));
var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(swagger =>
    {
        swagger.SwaggerEndpoint("/swagger/v1/swagger.json", "Swagger-Hangfire-Supabase v1");
    });
}
app.UseRouting();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.UseAuthentication();
app.UseHangfireDashboard("/hangfire");

// Jobs & Methoden ausführen
RecurringJob.AddOrUpdate<ProcessingJob>(
    "Console-Verification",
    job => job.ConsoleVerification(),
    "*/2 * * * *");

RecurringJob.AddOrUpdate<ProcessingJob>(
    "Developer-Information",
    job => job.DeveloperVerification(),
    "*/1 * * * *");

app.Run();
