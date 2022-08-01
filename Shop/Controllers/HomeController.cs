using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.ViewModels;

namespace Shop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAllCars carRep;
        
        public HomeController(IAllCars carRep)
        {
            this.carRep = carRep;
           
        }

        public ViewResult Index() {

            var homecars = new HomeViewModel
            {
                favCar = carRep.GetFavoriteCars
            };

        return View(homecars);
        }

    }
}
