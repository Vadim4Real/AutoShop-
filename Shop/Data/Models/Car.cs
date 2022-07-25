namespace Shop.Data.Models
{
    public class Car
    {
        public int Id { get; set; }   // id товара
        public string Name { get; set; } // название 
        public string ShortDesc { get; set; } // описание
        public string LongDes { get; set; } // длинное описанеи
        public string Img { get; set; } // картинка (URL адрес) 
        public ushort price { get; set; } // цена (не может быть цена с минус потому и ushort)
        public bool isFavorite { get; set; } // отображение на главной странице
        public bool Available { get; set; } // есть ли товар на складе
        public int CategoryID  { get; set; } // каждый товар приклеплен к категории опредленной
        public virtual Category Category { get; set; }  // создаем отбьект с значением 
    }
}
