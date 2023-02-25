using DataTransfer.Models;
using Microsoft.AspNetCore.Mvc;

namespace DataTransfer.ViewComponents
{
    public class AppartmentViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            List<Hotels>hotels = new List<Hotels>()
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
            return View(hotels);
        }
    }
}
