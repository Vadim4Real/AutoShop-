
using Shop.Pages.Models;
using Shop.Pages.Models.Interfaces;

namespace Shop.Data.Mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories {

            get { return new List<Category> 
            { new Category { CategoryName = "Электромобили",desc="Современные автомобили" },
              new Category { CategoryName = "Бензиновые авто",desc="Двигатели внутренного сгорания" }
            }; 
            }
        }
    }
}
