using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodingPlayground
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var quotes = new[] { 1, 2, 3, 4, 5, 6, 7 };

            var quotes2 = new[] { 7, 6, 5, 4, 3, 2, 1 };

            var quotes3 = new[] { 5, 6, 4, 6, 8, 1 };

            var maxProfit1 = MaxProfit(quotes);
            var maxProfit2 = MaxProfit(quotes2);
            var maxProfit3 = MaxProfit(quotes3);

            if (maxProfit1 != 6) throw new System.Exception("Error");
            if (maxProfit2 != 0) throw new System.Exception("Error");
            if (maxProfit3 != 4) throw new System.Exception("Error");
            if (MaxProfit(new int[0]) != 0) throw new System.Exception("Error");
            Console.WriteLine("All good");

        }

        /// <summary>
        /// This was an interesting challenge. 
        /// Given an array of ints representing stock price quotes every hour, 
        /// calculate the max profit you could make for the day. 
        /// The challenge was that this is a time based array and ordering matters.
        /// for example { 5, 6, 4, 6, 8, 1 } the max profit here is 4, 
        /// the price of the stock at array[2] increases to 8 at array[4]
        /// </summary>
        /// <param name="quotes">The stock prices quotes array</param>
        /// <returns>The maximum profit made.</returns>
        private static int MaxProfit(int[] quotes)
        {
            if (quotes.Length <= 1)
            {
                return 0;
            }

            int min = quotes[0];
            int currentProfit = 0;

            for (int i = 0; i <= quotes.Length - 1; i++)
            {
                if (quotes[i] < min)
                    min = quotes[i];

                int potentialProfit = quotes[i] - min;

                if (potentialProfit > 0 && potentialProfit > currentProfit)
                {
                    currentProfit = potentialProfit;
                }

            }

            return currentProfit;
        }
    }
}
