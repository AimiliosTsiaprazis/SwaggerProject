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
var supabaseUrl = "https://vgmjsqgxhyiytgiasytq.supabase.co";
var supabaseKey = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6InZnbWpzcWd4aHlpeXRnaWFzeXRxIiwicm9sZSI6ImFub24iLCJpYXQiOjE3NTA5MzA2MzksImV4cCI6MjA2NjUwNjYzOX0.qJ4M064Cnx3OJ65sY8Ut946r6d3lNp6MjWkfiumuqSI";

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
