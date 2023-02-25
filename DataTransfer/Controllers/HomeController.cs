using DataTransfer.Models;
using DataTransfer.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DataTransfer.Controllers
{
    public class HomeController : Controller
    {
        public List<Hotels> Hotels;
        public List<Category> Categories;
        public HomeController()
        {
            Hotels = new List<Hotels>()
            {
                new Hotels()
                {
                    Price = 100,
                    Name = "Diamond",
                    Description="Comfortable",
                    CoverPhoto="https://res.cloudinary.com/dddptppkn/image/upload/v1668256782/myfolder/mysubfolder/single-room_xdnyxn.jpg"
                },
                new Hotels()
                {
                    Price = 299,
                    Name = "Gold",
                    Description="Comfortable Lorem Ipsum",
                    CoverPhoto="https://res.cloudinary.com/dddptppkn/image/upload/v1668256678/myfolder/mysubfolder/double-room_xadsv0.jpg"
                },
                new Hotels()
                {
                    Price = 599,
                    Name = "Baleli",
                    Description="Comfortable Lorem Ipsum",
                    CoverPhoto="https://res.cloudinary.com/dddptppkn/image/upload/v1668256678/myfolder/mysubfolder/double-room_xadsv0.jpg"
                },
                new Hotels()
                {
                    Price = 799,
                    Name = "Nurlan",
                    Description="Comfortable Lorem Ipsum",
                    CoverPhoto="https://res.cloudinary.com/dddptppkn/image/upload/v1668256727/myfolder/mysubfolder/lux_yrptmb.jpg"
                },
                new Hotels()
                {
                    Price = 1000,
                    Name = "Modern",
                    Description="Lorem Ipsum",
                    CoverPhoto="https://www.bestwesternplusmeridian.com/Content/images/Queen-Room-o.jpg"
                },
                new Hotels()
                {
                    Price = 1500,
                    Name = "Junior",
                    Description="Lorem Ipsum",
                    CoverPhoto="https://www.bestwesternplusmeridian.com/Content/images/exicutiveroom_o.jpg"
                },
            };
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
            Categories = new List<Category>()
            {
              cat1, cat2, cat3, cat4, cat5
            };
        }
        public ActionResult Index()
        {

            HotelVM model = new HotelVM()
            {
                Hotels = Hotels,
                Categories = Categories,
            }; 
            return View(model);
        } 
    }  
}
