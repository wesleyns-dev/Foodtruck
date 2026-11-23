using FoodTruck.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FoodTruck.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateCategory([FromBody] Category category)
        {
            if (string.IsNullOrWhiteSpace(category.Name) || category.Price <= 0)
            {
                return BadRequest("Invalid category data.");
            }

            Category categoria1 = new Category
            {
                Name = category.Name,
                Price = category.Price
            };

            return Ok(categoria1);
        }
        
        [HttpGet]
        public IActionResult GetAllCategories()
        {
            return Ok(new List<Category>
            {
                new Category { Name = "Burgers", Price = 5.99m },
                new Category { Name = "Tacos", Price = 3.99m },
                new Category { Name = "Drinks", Price = 1.99m }
            });
        }
    }
}
