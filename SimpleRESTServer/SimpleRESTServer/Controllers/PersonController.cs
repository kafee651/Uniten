using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SimpleRESTServer.Models;

namespace SimpleRESTServer.Controllers
{
    public class PersonController : ApiController
    {
        // GET: api/Person
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Person/5
        public Person Get(int id)
        {
            Person person = new Person();

            person.ID = id;
            person.LastName = "Uddin";
            person.FirstName = "Mohammad Kafee";
            person.PayRate = 54.54;
            person.StartDate = DateTime.Parse("17/06/2013");
            person.EndDate = DateTime.Parse("16/05/2018");

            return person;
        }

        // POST: api/Person
        public void Post([FromBody]Person value)
        {
            Console.WriteLine(value.FirstName);
        }

        // PUT: api/Person/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Person/5
        public void Delete(int id)
        {
        }
    }
}
