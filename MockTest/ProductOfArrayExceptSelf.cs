using System;
using System.Collections.Generic;

namespace ConsoleApp55
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] para = { 1, 2, 3, 4 };
            ProductExceptSelf(para);
        }

        static int[] ProductExceptSelf(int[] nums)
        {
            List<int> answerList = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                List<int> array = new List<int>(nums);
                array.RemoveAt(i);
                int element = 1;
                for (int q = 0; q < array.Count; q++)
                {
                    element *= array[q];
                }
                answerList.Add(element);
            }

            int[] answer = answerList.ToArray();
            return answer;
        }
    }
}
