using System;
using System.Collections.Generic;

namespace ConsoleApp76
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
        }
        public int MaxProfit(int[] prices)
        {
            if (prices == null) return 0;
            Stack<int> s = new Stack<int>();
            for(int i = 0; i < prices.Length; i++)
            {
                for(int j = i; j < prices.Length; j++)
                {
                    int res = prices[j] - prices[i];
                    if (s.Count == 0) s.Push(res);
                    else if (s.Peek() < res)
                    {
                        s.Pop();
                        s.Push(res);
                    }
                }
            }
            int answer = s.Peek();
            return answer;
        }
        
    }
}
