using DataTransfer.Models;
using Microsoft.AspNetCore.Mvc;

namespace DataTransfer.Controllers
{
    public class CategoryController:Controller
    {
        public ActionResult CategoryPage()
        {
            return View();
        }
    }
}
