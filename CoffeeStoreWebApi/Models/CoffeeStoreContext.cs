using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CoffeeStoreWebApi.Models
{
    /// <summary>
    /// list of my coffees
    /// </summary>
    public class CoffeeStoreContext:DbContext
    {
        public DbSet<Coffee> CoffeList { get; set; }
    }
}