using System;

namespace ConsoleApp69
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] para = { 1,3, 5, 7, 9 ,11,13,15,17,19};
            int target = 190;
            int answer=SearchInsert(para, target);
            Console.WriteLine("Hello World!");
        }

        static public int SearchInsert(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;

            if (target > nums[right]) return right + 1;
            if (target < nums[left]) return left;

            while (left<=right)
            {
                int middle = (left + right) / 2;
                if (target == nums[middle]) return middle;
                else if (target > nums[middle])
                {
                    if (target < nums[middle + 1]) return middle + 1;
                    else left = middle+1;
                }
                else
                {
                    if (target > nums[middle - 1]) return middle ;
                    else right = middle-1;
                }
            }
            return -1;
        }
    }
}
