using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101_Assignment1_CatherineTran.Controllers
{
    public class NumberMachineController : ApiController
    {
        /// <summary>
        /// Question 5.
        /// This method returns the input {id} with
        /// four mathematical operations applied to it
        /// <example>GET api/NumberMachine</example>
        /// </summary>
        /// <param name="id"></param>
        /// <returns>
        /// [1. id = 10 returns 12]
        /// [2. id = -5 returns -9]
        /// [3. id = 30 returns 40]
        /// </returns>
        public IEnumerable<int> Get(int id)
        {
            return new int[] {( id / 5) * (1 + 6) - 2};
        }
    }
}
