namespace FoodTruck.Models
{
    public class Customer
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Telephone { get; set; } = string.Empty;
        public string Adress { get; set; } = string.Empty;

        //Um cliente pode ter muitos pedidos
        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
