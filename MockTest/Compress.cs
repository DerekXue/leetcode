using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp59
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] para = { 'a', 'a', 'b', 'b', 'c' };
            int answer=Compress(para);
            Console.WriteLine("Hello World!");
        }

        static public int Compress(char[] chars)
        {
            int i = 0;
            List<char> answer = new List<char>();
            while(i<=chars.Length-1)
            {
                int q = i + 1;
                int counter = 1;
                while (q<=chars.Length-1&&chars[i] == chars[q])
                {
                    q++;
                    counter++;
                }
                answer.Add(chars[i]);
                char[] charAnswer=counter.ToString().ToCharArray();
                if (i != chars.Length - 1)
                {
                    foreach (char c in charAnswer)
                    {
                        answer.Add(c);
                    }
                }
                i = q;
            }
            int theAnswer = answer.Count();
            return theAnswer;
        }
        
    }
}
