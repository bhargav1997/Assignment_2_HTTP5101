using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Assignment2.Controllers
{
    [Route("api/[controller]")]
    public class DiceGameController : Controller
    {

        /// <summary>
        /// Counts the number of ways to roll a sum of 10 with two dice, where the first die has m sides and the second die has n sides.
        /// </summary>
        /// <param name="m">The number of sides on the first die.</param>
        /// <param name="n">The number of sides on the second die.</param>
        /// <returns>A string representing the number of ways to roll a sum of 10.</returns>
        // GET: /api/J2/DiceGame/{m}/{n}
        [HttpGet("/api/J2/DiceGame/{m}/{n}")]
        public string CountWaysToRollTen(int m, int n)
        {
            // Initialize count of ways to roll 10
            int count = 0;

            // Iterate through all possible values on the first die
            for (int i = 1; i <= m; i++)
            {
                // Check if rolling i on first die and 10 - i on second die results in sum 10
                if (10 - i >= 1 && 10 - i <= n)
                {
                    // Increment count if valid combination found
                    count++;
                }
            }

            // Return count of ways to roll 10 as JSON response
            return $"Number of ways to roll the value of 10: {count}";
        }
    }
}

