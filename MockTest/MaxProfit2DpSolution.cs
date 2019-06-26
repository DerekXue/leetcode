using System;

namespace ConsoleApp78
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public int MaxProfit(int[] prices)
        {
            int buy = int.MaxValue;
            int profit = 0;
            int sum = 0;
            foreach(int price in prices)
            {
                buy = Math.Min(buy, price);
                profit = Math.Max(profit, price - buy);
                if (profit > 0)
                {
                    sum += profit;
                    profit = 0;
                    buy = price;
                }
            }
            return sum;
        }

    }
}
