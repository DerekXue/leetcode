using System;
using System.Collections.Generic;
using System.Linq;


namespace ConsoleApp64
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer=convertion("((((1+2)*(3-4))/4)*(12+5))*((((1+2)*(3-4))/4)*(12+5))+((((1+2)*(3-4))/4)*(12+5))*((((1+2)*(3-4))/4)*(12+5))");
            Console.WriteLine(answer);
            Console.ReadKey();
        }

        static public string convertion(string exp)
        {
            exp.ToCharArray();
            Stack<char> stack = new Stack<char>();
            Stack<int> lvlStack = new Stack<int>();
            List<char> list = new List<char>();
            int curlvl = 0;

            foreach(char c in exp)
            {
                if (char.IsDigit(c)) list.Add(c);
                else if (c == ' ') continue;
                else
                {
                    switch (c)
                    {
                        case '+':
                            curlvl = 1;
                            break;
                        case '-':
                            curlvl = 1;
                            break;
                        case '*':
                            curlvl = 2;
                            break;
                        case '/':
                            curlvl = 2;
                            break;
                        case '(':
                            stack.Push(c);
                            continue;
                        case ')':
                            while (stack.Peek() != '(')
                            {
                                list.Add(stack.Peek());
                                stack.Pop();
                            }
                            stack.Pop();
                            continue;
                    }
                    
                    while (lvlStack.Count != 0&& stack.Count != 0 && curlvl <= lvlStack.Peek()&&stack.Peek()!='(')
                    {
                        list.Add(stack.Pop());
                        lvlStack.Pop();
                    }
                    stack.Push(c);
                    lvlStack.Push(curlvl);
                }
            }
            while(stack.Count()!=0)
            {
                list.Add(stack.Pop());
            }

            string newExp ="";
            foreach (char c in list) newExp += c;
            return newExp;
        }
    }
}
