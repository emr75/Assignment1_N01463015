using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class HostingCostController : ApiController
    {

        /// <summary>
        /// This method returns the total cost for web hosting and maintenance
        /// </summary>
        /// <example> GET api/HostingCost/{id} </example>
        /// <returns> “(number of fortnights) fortnights at $5.50/FN = $(cost) CAD”, “HST 13% = $(tax) CAD”, “Total = $(total)” </returns>
        public IEnumerable<string> Get(int id)
        {
            double cost = (id * 5.50 + 5.50);
            double tax = (cost * 0.13);
            double total = (cost + tax);

            return new string[] { (id) + " fortnights at $5.50/FN = $" + (cost) + " CAD" , "HST 13% = $" + (tax) + " CAD" , "Total = $" + (total) + " CAD" };
        }





    }
}
