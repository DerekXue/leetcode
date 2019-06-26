using System;
using System.Collections.Generic;

namespace ConsoleApp65
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class PhoneDirectory
    {
        List<int> phoneNumebr;
        /** Initialize your data structure here
            @param maxNumbers - The maximum numbers that can be stored in the phone directory. */
        public PhoneDirectory(int maxNumbers)
        {
            phoneNumebr = new List<int>(new int[maxNumbers]);
            for (int i = 0; i < phoneNumebr.Count; i++)
            {
                phoneNumebr[i] = i;
            }
        }

        /** Provide a number which is not assigned to anyone.
            @return - Return an available number. Return -1 if none is available. */
        public int Get()
        {
            int returnNum = 0;
            if(phoneNumebr.Count!=0)
            {
                returnNum = phoneNumebr[0];
                phoneNumebr.RemoveAt(0);
            }
            return returnNum;
        }

        /** Check if a number is available or not. */
        public bool Check(int number)
        {
            if (phoneNumebr.Contains(number)) return true;
            else return false;
        }

        /** Recycle or release a number. */
        public void Release(int number)
        {
            if (phoneNumebr.Contains(number)) phoneNumebr.Remove(number);
            else return;
        }
    }

    /**
     * Your PhoneDirectory object will be instantiated and called as such:
     * PhoneDirectory obj = new PhoneDirectory(maxNumbers);
     * int param_1 = obj.Get();
     * bool param_2 = obj.Check(number);
     * obj.Release(number);
     */
}
