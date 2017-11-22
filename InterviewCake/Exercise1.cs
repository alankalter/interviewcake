using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCake
{
    class Exercise1
    {
        public static void Run()
        {
            int[] stockPricesYesterday = { 10, 7, 5, 8, 11, 9 };

            Console.WriteLine(GetMaxProfit(stockPricesYesterday));
            Console.ReadKey();
        }
        private static int GetMaxProfit(int[] prices)
        {
            int currentMax = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                for (int j = i + 1; j < prices.Length; j++)
                {
                    if ((prices[i] - prices[j]) > currentMax)
                    {
                        currentMax = prices[i] - prices[j];
                    }
                }
            }

            return currentMax > 0 ? currentMax : 0;
        }
    }
}
