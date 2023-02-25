using DataTransfer.Models;
using Microsoft.AspNetCore.Mvc;

namespace DataTransfer.ViewComponents
{
    public class CategoryViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Category cat1 = new Category()
            {
                Id = 1,
                Name = "Family Room"
            };
            Category cat2 = new Category()
            {
                Id = 2,
                Name = "Single Room"
            };
            Category cat3 = new Category()
            {
                Id = 3,
                Name = "Double Room"
            };
            Category cat4 = new Category()
            {
                Id = 4,
                Name = "Vip Room"
            };
            Category cat5 = new Category()
            {
                Id = 5,
                Name = "Lux Room"
            };
            List<Category> categories = new List<Category>()
            {
              cat1, cat2, cat3, cat4, cat5
            };

            return View(categories);
        }
    }
}
