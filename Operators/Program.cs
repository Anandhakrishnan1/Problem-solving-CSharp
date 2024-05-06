using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double meal_cost = Convert.ToDouble(Console.ReadLine().Trim());

            int tip_percent = Convert.ToInt32(Console.ReadLine().Trim());

            int tax_percent = Convert.ToInt32(Console.ReadLine().Trim());

            Result.solve(meal_cost, tip_percent, tax_percent);
        }

        public class Result
        {
            public static void solve(double meal_cost, int tip_percent, int tax_percent)
            {
                var tip_amount = (meal_cost * tip_percent) / 100;
                var tax_amount = (meal_cost * tax_percent) / 100;
                var totalAmount = meal_cost + tip_amount + tax_amount;
                Console.WriteLine(Math.Round(totalAmount));
            }
        }
    }
}
