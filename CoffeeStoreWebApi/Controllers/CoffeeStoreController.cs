using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using CoffeeStoreWebApi.Models;
using System.Web.Http.OData;

namespace CoffeeStoreWebApi.Controllers
{
    [EnableCorsAttribute("http://localhost:65335","*","*")]
    public class CoffeeStoreController : ApiController
    {
        // GET: api/CoffeeStore        
        public IEnumerable<Coffee> Get()
        {
            CoffeeStoreRepository repo = new CoffeeStoreRepository();
            return repo.GetCoffees();
        }

        // GET: api/CoffeeStore/5
        public Coffee Get(int id)
        {
            if (id > 0)
            {
                CoffeeStoreRepository repo = new CoffeeStoreRepository();
                return repo.GetCoffee(id);
            }
            else {
                return null;
            }
            
        }

        // POST: api/CoffeeStore
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/CoffeeStore/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/CoffeeStore/5
        public void Delete(int id)
        {
        }
    }
}
