using System;
using SwaggerProject.Modells;
using System.Collections.Generic;
using SupabaseService;

public class OrderService : IOrderService
{
    public readonly List<Order> _orders = new();
    private readonly SupabaseService.SupabaseService _supabaseService;
    public OrderService(SupabaseService.SupabaseService supabaseService):base()
    {
        _supabaseService = supabaseService;
    }
    public List<Order> GetOrders() => _orders;
    public async Task AddAsync(Order order)
    {
        _orders.Add(order); 

        try
        {
            System.Console.WriteLine("calling Supabase isert...");
            await _supabaseService.SaveServiceData(order);
            Console.WriteLine("Order saved to Supabase.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Failed to save customer: {ex.Message}");
        }
    }
}