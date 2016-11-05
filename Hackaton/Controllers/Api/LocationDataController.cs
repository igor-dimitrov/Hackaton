using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Hackathon.Models;

namespace Hackaton.Controllers.Api
{
    public class LocationDataController : ApiController
    {
        List<LocationData> locationDataList = new List<LocationData>(); 

        // GET: api/LocationData
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/LocationData/5
        public IHttpActionResult Get(int id)
        {
            return Ok("value");
        }

        // POST: api/LocationData
        public void Post([FromBody]LocationData locationData)
        {
            locationDataList.Add(locationData);
        }

        // PUT: api/LocationData/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/LocationData/5
        public void Delete(int id)
        {
        }
    }
}
