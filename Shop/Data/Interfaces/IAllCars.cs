namespace Shop.Pages.Models.Interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> Cars { get;  }
        IEnumerable<Car> GetFavoriteCars { get; set; }
        Car getCar(int carID);
    }
}
