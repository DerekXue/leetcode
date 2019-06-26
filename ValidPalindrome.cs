using System;

namespace ConsoleApp67
{
    class Program
    {
        static void Main(string[] args)
        {
            ValidPalindrome("catac");
            Console.WriteLine("Hello World!");
        }

        static public bool ValidPalindrome(string s)
        {
            int j = 0;
            int q = s.Length-1;
            int grace = 0;
            while (j <= q)
            {
                if (grace > 1) return false;
                if (s[j] == s[q])
                {
                    j++;
                    q--;
                    continue;
                }
                if (s[j] != s[q]&&(s[j + 1] == s[q]|| s[j] == s[q - 1]))
                {
                    grace++;
                    if (s[j + 1] == s[q]) j++; 
                    else if (s[j] == s[q - 1]) q--;
                }
                else
                {
                    return false;
                } 
            }
            return true;
        }
    }
}
