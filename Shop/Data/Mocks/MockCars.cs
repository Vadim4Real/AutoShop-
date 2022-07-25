
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
                        Img = "https://i.trse.ru/2015/02/tesla-model-s-2015-features.jpg",
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
                        Img = "https://img3.akspic.ru/attachments/crops/0/1/1/5/35110/35110-Lityye_diski-bmv_m5_2018-bmw_x3-bmw_x5-lichnyj_roskoshnyj_avtomobil-1920x1080.jpg",
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
                        Img = "https://get.wallhere.com/photo/car-vehicle-Nissan-sports-car-Nissan-370Z-performance-car-netcarshow-netcar-car-images-car-photo-2016-wheel-370Z-Nismo-supercar-land-vehicle-automotive-design-automotive-exterior-automobile-make-luxury-vehicle-bumper-449355.jpg",
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
                        Img = "https://s0.rbk.ru/v6_top_pics/media/img/7/42/754788781357427.jpeg",
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
