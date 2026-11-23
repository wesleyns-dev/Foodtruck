using Microsoft.EntityFrameworkCore;
using FoodTruck.Models;

namespace FoodTruck.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        //Mapeando as tabelas do banco de dados com base nas nossas Models
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Caso o DbContext seja chamado sem opções (como no comando de migration), 
            // usa-se o MySQL com a mesma string de conexão do appsettings.json
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql(
                    "Server=localhost;Database=SistemaPastelaria;Uid=root;Password=sua_senha_aqui;",
                    ServerVersion.AutoDetect("Server=localhost;Database=SistemaPastelaria;Uid=root;Password=Celio0108;")
                );
            }
        }
    }
}
