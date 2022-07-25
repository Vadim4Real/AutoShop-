
using Shop.Data.Interfaces;
using Shop.Data.Models;
using System.Linq;

namespace Shop.Data.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars {
            get {
                return new List<Car>
                {
                    new Car
                    {
                        Name = "TESLA",
                        ShortDesc = "Электрический",
                        LongDes = "С большим зарядом",
                        Img = "/img/tesla.jpg",
                        price = 10000,
                        isFavorite = true,
                        Available = true,
                        Category = _categoryCars.AllCategories.First()
                    },

                    new Car
                    {
                        Name = "BMW",
                        ShortDesc = "Немецкое качество",
                        LongDes = "Премиальный",
                        Img = "/img/bmw.jpg",
                        price = 20000,
                        isFavorite = true,
                        Available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car
                    {
                        Name = "Nissan",
                        ShortDesc = "Еще одна элдектричка",
                        LongDes = "С батарейкой",
                        Img = "/img/nissan.jpg",
                        price = 30000,
                        isFavorite = true,
                        Available = true,
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car
                    {
                        Name = "Renault",
                        ShortDesc = "Народный для франции",
                        LongDes = "но не для Росии",
                        Img = "/img/reno.jpeg",
                        price =40000,
                        isFavorite = true,
                        Available = true,
                        Category = _categoryCars.AllCategories.Last()
                    }

                };
            } }


            
        public IEnumerable<Car> GetFavoriteCars { get ; set ; }

        public Car getCar(int carID)
        {
            throw new NotImplementedException();
        }
    }
}
