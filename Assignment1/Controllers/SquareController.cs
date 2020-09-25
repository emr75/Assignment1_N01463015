using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class SquareController : ApiController
    {

        /// <summary>
        /// This method returns the result of a squared integer
        /// <example> GET api/Square/{id} </example>
        /// </summary>
        /// <returns>[id * id]</returns>
        public int Get(int id)
        {
            int squared = id * id;
            return squared;
        }
    }
}
