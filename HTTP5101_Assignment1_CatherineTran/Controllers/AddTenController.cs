using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101_Assignment1_CatherineTran.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        /// Question 1.
        /// This method returns an integer that is 10 more
        /// than the integer input {id}
        /// <example>GET api/AddTen</example>
        /// </summary>
        /// <param name="id"></param>
        /// <returns>
        /// [1. id=21 returns 31]
        /// [2. id=0 returns 10]
        /// [3. id=-9 returns 1]
        /// </returns>
        public IEnumerable<int> Get(int id)
        {
            return new int[] { id + 10 };
        }
    }
}
