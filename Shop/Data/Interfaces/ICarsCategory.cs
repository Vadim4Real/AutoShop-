using Shop.Pages.Models;
namespace Shop.Pages.Models.Interfaces
{
    public interface ICarsCategory 
    {
        IEnumerable<Category> AllCategories  { get; }
    }
}
