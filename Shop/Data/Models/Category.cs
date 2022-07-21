namespace Shop.Pages.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string desc { get; set; }
        public List<Car> cars { get; set; } // какие товары входят в категории
    }
}
