using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Data.Repository
{
    public class CategoryRep : ICarsCategory
    {
        private readonly AppDBContent appDBContent;
        public CategoryRep(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;

        }

        public IEnumerable<Category> AllCategories => appDBContent.Category;
    }
}
