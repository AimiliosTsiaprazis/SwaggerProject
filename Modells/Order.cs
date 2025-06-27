using Newtonsoft.Json;
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace SwaggerProject.Modells
{
    [Table("Orders")]
    public class Order: BaseModel
    {
        public Order() {}

        [PrimaryKey("id", false)]
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("ProductId")]
        public int ProductId { get; set; }
        [JsonProperty("CustomerId")]
        public int CustomerId { get; set; }
        [JsonProperty("OrderDate")]
        public DateTime OrderDate { get; set; }
    }
}