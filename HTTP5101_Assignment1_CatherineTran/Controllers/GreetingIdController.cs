using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101_Assignment1_CatherineTran.Controllers
{
    public class GreetingIdController : ApiController
    {
        /// <summary>
        /// Question 4.
        /// This method returns the string 
        /// "Greetings to {id} people!"
        /// where id is an integer value.
        /// <example>GET api/GreetingId</example>
        /// </summary>
        /// <param name="id"></param>
        /// <returns>
        /// [1. id = 3 "Greetings to 3 people!"]
        /// [2. id = 6 "Greetings to 6 people!"]
        /// [4. id = 0 "Greetings to 0 people!"]
        /// </returns>
        public IEnumerable<string> Get(int id)
        {
            return new string[] { "Greetings to" + " " + id + " " + "people!"};
        }
    }
}
