using Microsoft.EntityFrameworkCore;
using System.Data.Entity;

namespace Shop.Data.Models
{
    public class ShopCart
    {
        private readonly AppDBContent appDBContent;
        public ShopCart(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;

        }
        public string ShopCartId { get; set; }
        public List<ShopCartItem> ListShopItems { get; set; }

        public static ShopCart GetCart(IServiceProvider service) {
            ISession? session = service.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = service.GetService<AppDBContent>();
            string shopCartId = session.GetString("cartId") ?? Guid.NewGuid().ToString();
            session.SetString("cartId", shopCartId);
            return new ShopCart(context) { ShopCartId = shopCartId };
        }
        public void AddToCart(Car car ) {
            appDBContent.ShopCartItem.Add(new ShopCartItem
            {
                ShopCartId = ShopCartId,
                car = car,
                price = car.price

            }) ;
            appDBContent.SaveChanges();
        
        }
        public List<ShopCartItem> GetShopItems()
        {
            return appDBContent.ShopCartItem.Where(a => a.ShopCartId == ShopCartId).ToList();
        }
    }

}
