using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace a1N01572641.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// Returns your input number squared
        /// </summary>
        /// <param name="id">The input number</param>
        /// <returns>The input number squared</returns>
        // Get /api/square/{id}
        public int Get(int id)
        {
            return id*id;

        }
    }
}
