using System;
using SwaggerProject.Modells;
using System.Collections.Generic;

public class CustomerService : ICustomerService
{
    public readonly List<Customer> _customers = new();
    private readonly SupabaseService.SupabaseService _supabaseService;
    public CustomerService(SupabaseService.SupabaseService supabaseService):base()
    {
        _supabaseService = supabaseService;
    }
    public List<Customer> GetCustomers() => _customers;
    
    public async Task AddAsync(Customer customer)
    {
        _customers.Add(customer);

        try
        {
            System.Console.WriteLine("calling Supabase isert...");
            await _supabaseService.SaveServiceData(customer);
            Console.WriteLine("Customer saved to Supabase.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Failed to save customer: {ex.Message}");
        }
    }
}