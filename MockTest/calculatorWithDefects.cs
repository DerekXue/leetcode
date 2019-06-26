using System;
using System.Collections.Generic;
using System.Linq;


namespace ConsoleApp64
{
    class Program
    {
        static void Main(string[] args)
        {
            string newExp=convertion("(2+6* 3+5- (3*14/7+2)*5)+3");
            int answer = calculate(newExp);
            Console.WriteLine(answer);
            Console.ReadKey();
        }

        static public string convertion(string exp)
        {
            int bracketlvl = 0;
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
                            bracketlvl++;
                            continue;
                        case ')':
                            //if (bracketlvl !=1)
                            //{ 
                                while (stack.Peek() != '(')
                                {
                                    list.Add(stack.Peek());
                                    stack.Pop();
                                }
                                stack.Pop();
                            //}
                            //else
                            //{
                            //    while (stack.Count != 0)
                            //    {
                            //        if(stack.Peek()!='(') list.Add(stack.Peek());
                            //        stack.Pop();
                            //    }
                            //}
                            //bracketlvl--;
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

        static public int calculate(string exp)
        {
            Stack<int> stack = new Stack<int>();
            for(int i = 0; i < exp.Length; i++)
            {
                if (char.IsDigit(exp[i])) stack.Push(int.Parse(exp[i].ToString()));
                else
                {
                    int rop = stack.Pop();
                    int lop = stack.Pop();
                    int tanswer = 0;
                    switch (exp[i])
                    {
                        case '+': tanswer = lop + rop; break;
                        case '-': tanswer = lop - rop; break;
                        case '*': tanswer = lop * rop; break;
                        case '/':
                            if (lop == 0)
                            {
                                return 0;
                            }
                            tanswer = lop / rop; break;
                    }
                    stack.Push(tanswer);
                }               
            }
            int answer = stack.Peek();
            return answer;
        }
    }
}
