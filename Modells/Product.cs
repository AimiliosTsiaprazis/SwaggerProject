using System;
using Supabase.Postgrest.Models;
using Supabase.Interfaces;
using Supabase.Realtime;
using Newtonsoft.Json;
using Supabase.Postgrest.Attributes;

namespace SwaggerProject.Modells
{
    [Table("Products")]
    public class Product : BaseModel
    {
        public Product() {}
        [PrimaryKey("id", false)]
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("Name")]
        public string Name { get; set; }
        
        [JsonProperty("Price")]
        public double Price { get; set; }
    }
}