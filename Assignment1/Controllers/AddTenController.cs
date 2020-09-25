using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        /// This method adds Ten to the inputted integer returning the total
        /// <example> GET api/AddTen/{id} </example>
        /// </summary>
        /// <returns>[id + 10]</returns>
        public int Get(int id)
        {
            int sum = id + 10;
            return sum;
        }
    }
}
