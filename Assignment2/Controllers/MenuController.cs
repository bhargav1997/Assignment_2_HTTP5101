using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Assignment2.Controllers
{
    [Route("api/[controller]")]
    public class Menu : Controller
    {

        // GET: /api/J1/Menu/{burger}/{drink}/{side}/{dessert}
        [HttpGet]
        [Route("/api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        public string CalculateTotalCalories(int burger, int drink, int side, int dessert)
        {
            // set calorie values for each menu item
            int[] burgerCalories = { 461, 431, 420, 0 };
            int[] drinkCalories = { 130, 160, 118, 0 };
            int[] sideCalories = { 100, 57, 70, 0 };
            int[] dessertCalories = { 167, 266, 75, 0 };

            // Calculate total calories based on user's choice
            int totalCalories = burgerCalories[burger - 1] + drinkCalories[drink - 1] + sideCalories[side - 1] + dessertCalories[dessert - 1];

            // Return total calories as JSON response
            return $"Your total calorie count is {totalCalories}";
        }
    }
}

