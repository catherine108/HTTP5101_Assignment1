
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101_Assignment1_CatherineTran.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// Question 2.
        /// This method returns the square of the
        /// integer input {id}
        /// <example>GET api/Square</example>
        /// </summary>
        /// <param name="id"></param>
        /// <returns>
        /// [1. id=2 returns 4]
        /// [2. id=-2 returns 4]
        /// [3. id=10 returns 100]
        /// </returns>
        public IEnumerable<int> Get(int id)
        {
            return new int[] { id * id };
        }
    }
}
