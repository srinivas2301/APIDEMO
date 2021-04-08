using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIDEMO.Controllers
{
    public class BikesController : ApiController
    {
        List<string> bikes = initbikes();

        public static List<string> initbikes()
        {
            var bikes = new List<string>() { "yamaha", "pulsar", "honda" };
            return bikes;
        }
        // GET: api/Bikes
        public IEnumerable<string> Get()
        {
            return bikes;
        }

        // GET: api/Bikes/5
        public string Get(int id)
        {
            return bikes[id];
        }

        // POST: api/Bikes
        public void Post([FromBody]string value)
        {
            bikes.Add(value);  
        }

        // PUT: api/Bikes/5
        public void Put(int id, [FromBody]string value)
        {
            bikes[id] = value;
        }

        // DELETE: api/Bikes/5
        public void Delete(int id)
        {
            bikes.RemoveAt(id);
        }
    }
}
