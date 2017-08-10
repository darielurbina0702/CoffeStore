using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoffeeStoreWebApi.Models
{   
        /// <summary>
        /// details of my coffee ( try to add more depending on the time)
        /// </summary>
        public class Coffee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public double Price { get; set; }
            public string ImgUrl { get; set; }
        }
    
}