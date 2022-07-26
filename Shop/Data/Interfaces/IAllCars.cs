using Shop.Data.Models;

namespace Shop.Data.Interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> Cars { get;  }
        IEnumerable<Car> GetFavoriteCars { get;}
        Car getCar(int carID);
    }
}
