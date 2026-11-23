namespace FoodTruck.Models
{
    public class Category
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }

        //Relação de uma categoria para muitos produtos
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
