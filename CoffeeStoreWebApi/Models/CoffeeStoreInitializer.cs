using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CoffeeStoreWebApi.Models
{
    //i use dropcreatealways for learning resons
    public class CoffeeStoreInitializer : DropCreateDatabaseAlways<CoffeeStoreContext>
    {  
            /// <summary>
            /// initializing my database using codefirst
            /// adding some values that will stay always as default
            /// </summary>
            /// <param name="context"></param>
            protected override void Seed(CoffeeStoreContext context)
            {
                var list = new List<Coffee>
            {
                new Coffee() {Id = 1,Name = "Mocha Frappuccino",Price = 3.50,ImgUrl="../img/mochafrap.jpg" },
                new Coffee() {Id = 2,Name = "Hot Chocolate",Price = 2.50,ImgUrl="../img/hotchocolate.jpg"  },
                new Coffee() {Id = 3,Name = "Espresso",Price = 3.85 ,ImgUrl="../img/espresso.jpg" },
                new Coffee() {Id = 4,Name = "Cappuccino",Price = 3.15 ,ImgUrl="../img/cappuccino.jpg" },
                new Coffee() {Id = 5,Name = "Iced Caramel Macchiato",Price = 3.50 ,ImgUrl="../img/icedcaramelmacchiato.jpg" },
                new Coffee() {Id = 6,Name = "Frappuccino",Price = 4.10 ,ImgUrl="../img/frappuccino.jpg" },
                 new Coffee() {Id = 7,Name = "Latte",Price = 3.50 ,ImgUrl="../img/latte.jpg" },
                new Coffee() {Id = 8,Name = "Pumpkin Spice Latte",Price = 2.50 ,ImgUrl="../img/pumpkinspicelatte.jpg" }            

            };

                list.ForEach(coffe => context.CoffeList.Add(coffe));
                context.SaveChanges();
                base.Seed(context);
            }
        
    }
}