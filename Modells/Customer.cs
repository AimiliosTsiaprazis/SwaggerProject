using System;
using Supabase.Postgrest.Models;
using Supabase.Interfaces;
using Supabase.Realtime;
using Newtonsoft.Json;
using Supabase.Postgrest.Attributes;

namespace SwaggerProject.Modells
{
    [Table("Customers")]
    public class Customer : BaseModel
    {
        public Customer() { }

        [PrimaryKey("id", false)]
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }
}