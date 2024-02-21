using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Assignment2.Controllers
{
    [Route("api/[controller]")]
    public class SumacSequenceController : Controller
    {
        /// <summary>
        /// Retrieves the length of the Sumac Sequence for the given starting numbers.
        /// </summary>
        /// <param name="t1">The first number of the sequence.</param>
        /// <param name="t2">The second number of the sequence.</param>
        /// <returns>The length of the Sumac Sequence.</returns>
        /// <example> GET: /api/J3/sumacsequence/120/71 ==> 5 </example>
        /// <example> GET: /api/J3/sumacsequence/49/22 ==> 3 </example>
        [HttpGet]
        [Route("/api/J3/sumacsequence/{t1}/{t2}")]
        public int CalculateSequenceLength(int t1, int t2)
        {
            //  Sumac sequence length counter
            int length = 2;

            // Generate sumac sequence until tm-1 < tm
            while (t2 >= 0 && t1 >= t2)
            {
                // Calculate next term in sumac sequence
                int tn = t1 - t2;
                t1 = t2;
                t2 = tn;
                // Increment sequence length
                length++;
            }

            return length;
        }
    }
}

    