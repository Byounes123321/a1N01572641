using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace a1N01572641.Controllers
{
    public class HostingCostController : ApiController
    {
        //I was not able to complete this question but you said in class that you would want a discription of how I was trying to solve it.
        public string Get(int id)
        {
            int fn = (id / 14) + 1;
            int tax = perFn * .13;
            int afterTax = tax + perFn;
            string perFn = fn * 5.50;
            //First I did all of the math required to solve this problem and I saved thoes answers as integer variables
            
            string fortNit;
             fortNit = fn.ToString();

            string taxes;
            taxes = tax.ToString();

            string aTax;
            aTax = afterTax.ToString();
            //Then I turned the integers into strings so that they can be added to the final output strings

            string line1 =  fortNit + " fortnights at $" + perFn + "/FN = $" + perFn + "CAD";
            string line2 =  "HST 13% = $" + taxes "CAD";
            string line3 = "Total = $" + aTax + "CAD";
            //Then, I added the strings together to create each line individually 
            return {line1,line2,line3};
            //Finally, I return the three variables that contain the strings I want to display
        }
    }
}

