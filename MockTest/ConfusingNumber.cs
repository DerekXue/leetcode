using System;
using System.Collections.Generic;

namespace ConsoleApp62
{
    class Program
    {
        static void Main(string[] args)
        {
            ConfusingNumber(11);
            Console.WriteLine("Hello World!");
        }

            static public bool ConfusingNumber(int N)
            {
                int originN = N;
                bool flag = true;
                Dictionary<int, int> dic = new Dictionary<int, int>();
                int[] valid = new int[] { 0, 1, 9, 8, 6 };
                int[] corres = new int[] { 0, 1, 6, 8, 9 };
                for(int j=0;j<valid.Length;j++)
                {
                    dic.Add(valid[j], corres[j]);
                }
                List<int> Num = new List<int>();
                while (N > 0)
                {
                    Num.Add(N % 10);
                    N /= 10;
                }
                int ans = 0;
                for(int q = 0; q <= Num.Count - 1; q++)
                {
                int x = Num[q];
                    if(dic.ContainsKey(Num[q]))
                    {
                        ans *= 10;
                        ans += dic[Num[q]];
                    }
                    else
                    {
                        flag = false;
                    }
                }
                
                if (ans == originN) flag = false;
                return flag;
            }
        
    }
}
