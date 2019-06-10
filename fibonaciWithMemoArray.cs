using System;

namespace ConsoleApp52
{
    class Program
    {
        static void Main(string[] args)
        {
            long answer = fiboByIndex(20);
            int answer2 = fiboByIndex2(20, memo, true);
            Console.WriteLine(answer);
            Console.ReadLine();
        }

        static long fiboByIndex(int index)
        {
            int first = 0;
            int second = 1;
            int third = 0;

            if (index == 1) return 0;
            if (index == 2) return 1;

            else
            {
                for (int i = 0; i < index - 1; i++)
                {
                    third = first + second;
                    first = second;
                    second = third;
                }
                return third;
            }
        }

        static int[] memo;

        static int fiboByIndex2(int index, int [] memo,bool flag)
        {
            if (flag)
            {
                memo= new int[index+1];
                flag = false;
            }
            if (index == 1) return 0;
            if (index == 2) return 1;
            else
            {
                int value = fiboByIndex2(index - 1, memo,flag) + fiboByIndex2(index - 2, memo, flag);
                memo[index] = value;
                return value;
            }
        }



        //static int fiboByNumber(int number)
        //{
        //    int index = 0;


        //    if (number == 0) return 0;
        //    if (number == 1) return 1;

        //}



    }
}
