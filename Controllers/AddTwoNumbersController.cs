//Pedro Castaneda
//10-25-2022
//Add 2 Numbers - Endpoint
//Ask user for two numbers then function adds them together
//Peer Review by; Kent T. Works like its intended to do. Like I got to see the problem and not just the sum of the number.
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace castanedaPAddTwoNumbersEndpoint.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddTwoNumbersController : ControllerBase
    {
        [HttpGet("Adding/{num1}/{num2}")]
        public string Math(string num1, string num2)
        {
            int validNum1 = 0;
            int validNum2 = 0;
            bool checkNum1 = Int32.TryParse(num1, out validNum1);
            bool checkNum2 = Int32.TryParse(num2, out validNum2);
            string result = $"{validNum1} + {validNum2} = {validNum1 + validNum2}";
            if(!checkNum1 || !checkNum2)
            {
                result = "Invalid Entry";
            }
            return result;
        }
    }        
}