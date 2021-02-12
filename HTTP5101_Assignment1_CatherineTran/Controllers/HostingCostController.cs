using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101_Assignment1_CatherineTran.Controllers
{
    public class HostingCostController : ApiController
    {
        // GET api/values
        //
        /// <summary>
        /// I would first approach this problem by setting up integer
        /// variables, perhaps using creating an array for the integer
        /// values that fall within a group fortnights such as 0-13,
        /// 14-27, 28-40. I would then write a method that is somewhat 
        /// along the lines of what I have below.
        /// <example>GET Api/HostingCost</example>
        /// [First string ] If the {id} falls
        /// within one of the arrays, it would return the corresponding
        /// number as a variable of  "1" "2" or "3" fortnights etc. 
        /// incorporated into a string. [Second string] I would aim
        /// to create something that would work along the lines of
        /// { "HST 13% =" + " $" + (id * 5.50) * (0.13) + "CAD"};
        /// [Third string] "Total = $" + (id * 5.50 + calculated tax value)
        /// + "CAD". I would continue to check and modify this, one step at a 
        /// time and use the error message as feedback to check if the syntax 
        /// is correct and makes sense. If the error explanations are vague,
        /// perhaps I could search to better understand the errors. 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        public IEnumerable<string> Get(float id)
           
        {
            return new string[] { id + "fortnights at $5.50/FN" + (id * 5.50) +
                "CAD" };
        }
    }
}
