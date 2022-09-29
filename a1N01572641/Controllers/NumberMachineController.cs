using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace a1N01572641.Controllers
{
    public class NumberMachineController : ApiController
    {
        /// <summary>
        /// Returns the input number after adding 10, subtracting 20, multiplying by 5, and dividing by 2
        /// 
        /// </summary>
        /// <param name="id">The input number</param>
        /// <returns>The input after four mathamatical opporations </returns>
        // /api/numbermachine/{id}
        public int get(int id)
        {
            int add = id + 10;
            int sub = add - 20;
            int mul = sub * 5;
            int div = mul / 2;
            
            return div;
        }
    }
}
