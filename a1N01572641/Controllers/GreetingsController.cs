using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace a1N01572641.Controllers
{
    public class GreetingsController : ApiController
    {

        /// <summary>
        /// Returns the string "Hello World!" as a post
        /// </summary>
        /// <returns>The String "Hello World!"</returns>
        // -d "" /api/greeting

        public void Post([FromBody] string value)
        {
        }
        public string Get()
        {
            return "Hello World!";
        }
       
        
        /// <summary>
        /// Returns Hello to the inout amout of people
        /// </summary>
        /// <param name="id">The amout of people you are saying hello too</param>
        /// <returns> Hello to {id} people!</returns>
        public string get(int id)
        {
            string hi = "Hello to ";
            string peeps = " People!";
            string final = hi + id + peeps;
            return final;
        }
    }
}
