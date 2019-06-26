using System;

namespace ConsoleApp58
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] para = new int[] { 1, 3, 5, 6, 9, 10, 13 };
            int answer=Search(para, 13);
            Console.WriteLine("Hello World!");
        }
       

        static public int Search(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (nums[mid] == target) return mid;
                else if (nums[mid] > target)
                {
                    right = --mid;
                }
                else if (nums[mid] < target)
                {
                    left = ++mid;
                    
                }
            }
            return -1;
            
        }

    }
}
