using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.Data.Models;
using Shop.ViewModels;

namespace Shop.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;

        private readonly ICarsCategory _allCategories;

        public CarsController(IAllCars iallCars, ICarsCategory iCarsCat)
        {
            _allCars = iallCars;
            _allCategories = iCarsCat;
        }
        [Route("Cars/List")]
        [Route("Cars/List/{category}")]
        public ViewResult List( string category) 
        {
            string _category = category;
            IEnumerable<Car>? cars = null;            
            string currcategory = "";           
             if (string.IsNullOrEmpty(category)) {
                    cars = _allCars.Cars.OrderBy(i => i.Id);
                } else {
                    if (string.Equals("electro", category, StringComparison.OrdinalIgnoreCase))
                    {
                        cars = _allCars.Cars.Where(i => i.Category.CategoryName.Equals("Электромобили"));
                        currcategory = "Электро";

                    } else if (string.Equals("fuel", category, StringComparison.OrdinalIgnoreCase)) {

                        cars = _allCars.Cars.Where(i => i.Category.CategoryName.Equals("Бензиновые авто"));
                        currcategory = "Бензиновые";

                    };

                

            }

            var carObj = new CarsListViewModel
            {
                AllCars = cars,
                currCategory = currcategory
            };
            ViewBag.Title = "Страница с авто";
      
            return View(carObj);
     
        }

    }
}
