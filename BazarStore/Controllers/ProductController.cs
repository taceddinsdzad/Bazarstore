using BazarStore.Models;
using BazarStore.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BazarStore.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            List<Product> products = new List<Product>()
            {
              new Product(){image="https://www.google.com/url?sa=i&url=https%3A%2F%2Fbazarstore.az%2Fproducts%2Ffi%25CC%2587nal-qargidali-yagi-2-lt&psig=AOvVaw1Vtgfnzz4t7IgEext0dLjG&ust=1732111937945000&source=images&cd=vfe&opi=89978449&ved=0CBAQjRxqFwoTCJD10vfJ6IkDFQAAAAAdAAAAABAE",Id = 1, Name = "Final", Description = "Final gunebaxan", Price = 3.5m, DiscountPrice = 3, Category = "Qida", Color = "Yellow"},
                new Product(){image="https://www.google.com/url?sa=i&url=https%3A%2F%2Fumico.az%2Fproduct%2F541443-yoqurt-ivanovka-700-q-253782&psig=AOvVaw21xMv4yvWUL6NmlZpXKACh&ust=1732111853466000&source=images&cd=vfe&opi=89978449&ved=0CBAQjRxqFwoTCIjywc_J6IkDFQAAAAAdAAAAABAE",Id = 2, Name = "Ivanovka", Description = "Qatiq", Price = 1.8m, DiscountPrice = 1.5m, Category = "qida", Color = "White"}
            };
            ProductVM productsVM = new ProductVM
            {
                Products = products
            };
            return View(productsVM);
        }
    }
}
