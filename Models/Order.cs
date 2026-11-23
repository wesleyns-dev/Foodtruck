using System.Text.Json.Serialization;

namespace FoodTruck.Models
{
    public class Order
    {
        public long Id { get; set; }
        public DateTime DateTime { get; set; } = DateTime.Now;
        public string Status { get; set; } = "Pendente";
        public decimal TotalValue { get; set; }
        public string PaymentMethod { get; set; } = string.Empty;

        //Chave estrangeira para o cliente
        public long CustomerId { get; set; }

        [JsonIgnore]
        public Customer? Customer { get; set; }

        //Relação N:N mapeada pela tabela intermediária OrderItem 
        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}
