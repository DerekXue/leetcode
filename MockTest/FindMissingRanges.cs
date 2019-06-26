using System;
using System.Collections.Generic;

namespace ConsoleApp57
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 0, 1, 3, 50, 75 };
            int lower = 0;
            int upper = 99;
            IList<string> answer=FindMissingRanges(nums, lower, upper);

            Console.WriteLine("Hello World!");
        }

        static public IList<string> FindMissingRanges(int[] nums, int lower, int upper)
        {
            List<int> list = new List<int>(nums);
            list.Insert(0, lower);
            list.Add(upper);

            IList<string> answer = new List<string>();
            for(int i = 0; i < list.Count-1; i++)
            {
                int first = list[i];
                int second = list[i + 1];
                if (first + 1 == second || first == second) ;
                else if (first + 2 == second) answer.Add((first + 1).ToString());
                else answer.Add(((first+1)+"->"+ (second-1)).ToString());
            }
            return answer;
        }
    }
}
