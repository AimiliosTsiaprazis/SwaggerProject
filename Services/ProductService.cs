using System;
using SwaggerProject.Modells;
using System.Collections.Generic;
public class ProductService : IProductService
{
    public readonly List<Product> _products = new();
     private readonly SupabaseService.SupabaseService _supabaseService;

    public ProductService(SupabaseService.SupabaseService supabaseService):base()
    {
        _supabaseService = supabaseService;
    }
    public List<Product> GetProducts() => _products;
    public async Task AddAsync(Product product)
    {
        _products.Add(product); 

        try
        {
            System.Console.WriteLine("calling Supabase isert...");
            await _supabaseService.SaveServiceData(product);
            Console.WriteLine("Product saved to Supabase.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Failed to save customer: {ex.Message}");
        }
    }
}