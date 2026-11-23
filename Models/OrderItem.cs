using System.Text.Json.Serialization;

namespace FoodTruck.Models
{
    public class OrderItem
    {
        public long Id { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        //Chaves estrangeiras para Order e Product
        public long OrderId { get; set; }
        public long ProductId { get; set; }

        [JsonIgnore]
        public Order? Order { get; set; }

        [JsonIgnore]
        public Product? Product { get; set; }
    }
}
