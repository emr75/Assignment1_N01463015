using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class GreetingController : ApiController
    {

        /// <summary>
        /// This method returns the string "Hello World"
        /// <example> Post api/Gretting </example>
        /// </summary>
        /// <returns>["Hello World!"]</returns>
        public string Post()
        {
            return "Hello World!";
        }

        /// <summary>
        /// This method returns a greeting to the amount of people present
        /// </summary>
        /// <example> GET api/Greeting/{id} </example>
        /// <returns>["Greetings to (amount of people) people!"]</returns>
        public IEnumerable<string>Get(int id)
        {
            string amountofpeople = "Greetings to " + (id) + " people!";
            return new string[] { amountofpeople };
        }


    }
}
