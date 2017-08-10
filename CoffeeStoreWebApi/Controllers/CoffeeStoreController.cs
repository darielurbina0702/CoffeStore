using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using CoffeeStoreWebApi.Models;
using System.Web.Http.OData;
using System.Web.Http.Description;

namespace CoffeeStoreWebApi.Controllers
{
    [EnableCorsAttribute("http://localhost:65335", "*", "*")]
    public class CoffeeStoreController : ApiController
    {
        // GET: api/CoffeeStore
        [ResponseType(typeof(Coffee))]
        public IHttpActionResult Get()
        {
            try
            {
                CoffeeStoreRepository repo = new CoffeeStoreRepository();
                return Ok(repo.GetCoffees());
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }

        // GET: api/CoffeeStore/5
        [ResponseType(typeof(Coffee))]
        public IHttpActionResult Get(int id)
        {
            try
            {
                CoffeeStoreRepository repo = new CoffeeStoreRepository();
                if (id > 0)
                {
                    Coffee c = repo.GetCoffee(id);
                    if (c != null)
                        return Ok(c);
                }
                return NotFound();
            }
            catch (Exception e)
            {
                return InternalServerError(e);
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
