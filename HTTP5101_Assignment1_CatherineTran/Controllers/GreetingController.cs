using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101_Assignment1_CatherineTran.Controllers
{
    public class GreetingController : ApiController
    {
        /// <summary>
        /// Question 3.
        /// This method returns a string output
        /// of "Hello World!" executed in the
        /// Command Prompt
        /// <example>POST api/Greeting</example>
        /// </summary>
        /// <returns>["Hello World!"]</returns>
        public IEnumerable<string> Post()
        {
            return new string[] { "Hello World!" };
        }
    }
}
