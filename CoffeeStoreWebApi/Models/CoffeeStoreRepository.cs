using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace CoffeeStoreWebApi.Models
{
    public class CoffeeStoreRepository
    {
        CoffeeStoreContext db = new CoffeeStoreContext();
        public IEnumerable<Coffee> GetCoffees()
        {
            return db.CoffeList;
        }

        public Coffee GetCoffee(int id)
        {
            return db.CoffeList.FirstOrDefault<Coffee>(x => x.Id == id);
        }
      
    }
}