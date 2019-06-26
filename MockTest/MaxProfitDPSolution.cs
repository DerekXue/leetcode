using System;

namespace ConsoleApp77
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public int MaxProfit(int[] prices)
        {
            if (prices.Length == 0) return 0;
            else
            {
                int buy = int.MaxValue;
                int profit = 0;
                foreach(int price in prices) //price can be set to either buyin or selling price depend on max profit calculation
                {
                    buy = Math.Min(buy, price); //find the min buyin price through each iteration
                    profit = Math.Max(profit, price - buy); //find the max profit through each iteration
                }
                return profit;
            }
        }
    }
}
