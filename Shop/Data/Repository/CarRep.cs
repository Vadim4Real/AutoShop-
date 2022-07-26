using Shop.Data.Interfaces;
using Shop.Data.Models;
using System.Data.Entity;

namespace Shop.Data.Repository
{
    public class CarRep : IAllCars
    {


        private readonly AppDBContent appDBContent;
        public CarRep(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
            
        }
        

        public IEnumerable<Car> Cars => appDBContent.Cars.Include(c=>c.Category);

        public IEnumerable<Car> GetFavoriteCars => appDBContent.Cars.Where(p => p.isFavorite).Include(c => c.Category);

        public Car getCar(int carID) => appDBContent.Cars.FirstOrDefault(p => p.Id == carID);
        
    }
}
