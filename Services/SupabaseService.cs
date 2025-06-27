using System;
using System.Buffers.Text;
using Supabase;
using Supabase.Interfaces;
using Supabase.Postgrest;
using Supabase.Postgrest.Models;
using Supabase.Realtime;
using SwaggerProject.Modells;

namespace SupabaseService
{
    public class SupabaseService
    {
        private readonly Supabase.Client _supabaseClient;

        public SupabaseService(string url, string key)
        {
            var options = new Supabase.SupabaseOptions
            {
                AutoConnectRealtime = true
            };
            _supabaseClient = new Supabase.Client(url, key, options);
            _supabaseClient.InitializeAsync().GetAwaiter().GetResult();
        }
        public async Task SaveServiceData<T>(T data) where T: BaseModel, new()
        {
            try
    {
        var response = await _supabaseClient.From<T>().Insert(data);
        Console.WriteLine($"Saved: {response.Model}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Insert failed: {ex.Message}");
    }
        }
    }
}