using Shop.Data.Models;

namespace Shop.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
           /* AppDBContent content;
            using (var scope = app.ApplicationServices.CreateScope()) {
               
                content = scope.ServiceProvider.GetRequiredService<AppDBContent>();
            }*/
            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if (!content.Cars.Any()) {
                content.AddRange(
                    new Car
                    {
                        Name = "TESLA",
                        ShortDesc = "Электрический",
                        LongDes = "С большим зарядом",
                        Img = "/img/tesla.jpg",
                        price = 10000,
                        isFavorite = true,
                        Available = true,
                        Category = Categories["Электромобили"]
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
                            Category = Categories["Бензиновые авто"]
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
                            Category = Categories["Электромобили"]
                        },
                        new Car
                        {
                            Name = "Renault",
                            ShortDesc = "Народный для франции",
                            LongDes = "но не для Росии",
                            Img = "/img/reno.jpeg",
                            price = 40000,
                            isFavorite = true,
                            Available = true,
                            Category = Categories["Бензиновые авто"]
                        }


                    );
                content.SaveChanges();
            };



        }
        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {

                    var list = new Category[] {
                        new Category { CategoryName = "Электромобили", desc = "Современные автомобили" },
                        new Category { CategoryName = "Бензиновые авто", desc = "Двигатели внутренного сгорания" }
                    };

                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                        category.Add(el.CategoryName, el);
                }
                return category;
            }

        }
    }
}
       