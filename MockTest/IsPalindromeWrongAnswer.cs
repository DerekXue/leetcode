using System;
using System.Collections.Generic;

namespace ConsoleApp66
{
    class Program
    {
        static void Main(string[] args)
        {
            IsPalindrome("A man, a plan, a canal: Panama");
            Console.WriteLine("Hello World!");
        }

        static public bool IsPalindrome(string s)
        {
            s.ToLower();
            List<char> news=new List<char>(s.ToCharArray());
            for(int i = 0; i < news.Count; i++)
            {
                if (char.IsPunctuation(news[i])|| news[i]==' ')
                {
                    news.RemoveAt(i);
                }
            }
            Stack<char> stack = new Stack<char>();
            foreach(char i in news)
            {
                stack.Push(i);
            }
            List<char> revers = new List<char>();
            while (stack.Count != 0)
            {
                revers.Add(stack.Pop());
            }
            string output1 = new string(revers.ToArray());
            string output2 = new string(news.ToArray());
            if (output1 == output2) return true;
            else return false;
        }
    }
}
