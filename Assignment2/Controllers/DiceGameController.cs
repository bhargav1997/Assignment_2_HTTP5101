﻿using System;
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
        ///  Counts the number of ways to roll a sum of 10 with two dice,
        ///  where the first die has m sides and the second die has n sides.
        /// </summary>
        /// <param name="m">The number of sides on the first die.</param>
        /// <param name="n">The number of sides on the second die.</param>
        /// <returns>A string representing the number of ways to roll a sum of 10.</returns>
        /// <example>GET /api/J2/DiceGame/6/8 => There are 5 total ways to get the sum 10 </example>
        /// <example>GET /api/J2/DiceGame/12/4 => There are 4 ways to get the sum 10 </example>
        // GET: /api/J2/DiceGame/{m}/{n}
        [HttpGet("/api/J2/DiceGame/{m}/{n}")]
        public string CountWaysToRollTen(int m, int n)
        {
            int count = 0;

            // Counting the number of ways to roll a sum of 10 with two dice (m and n)
            for (int i = 1; i <= m; i++)
            {
                if (10 - i >= 1 && 10 - i <= n)
                {
                    count++;
                }
            }

            return "There are "+ count + " total ways to get the sum 10.";
        }
    }
}

