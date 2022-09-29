using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace a1N01572641.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        /// Adds ten to the number imputed
        /// </summary>
        /// <param name="id">The input number</param>
        /// <returns>The input number plus ten</returns>
        /// <example> Get 10 returns 20
        /// </example>
        
        //  Get /api/addten/{id}
        public int get(int id)
        {
            return id+10;
        }
    }
}
