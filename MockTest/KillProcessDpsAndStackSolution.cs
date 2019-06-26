using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp61
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<int> pid = new List<int>(new int[] { 1, 3, 10, 5 });
            IList<int> ppid = new List<int>(new int[] { 3, 0, 5, 3 });
            int kill = 3;
            killProcess(pid, ppid, kill);
            Console.WriteLine("Hello World!");
        }

        static public IList<int> killProcess(IList<int> pid, IList<int> ppid, int kill)
        {
            IList<int> answer = new List<int>();
            Dictionary<int, IList<int>> dic = new Dictionary<int, IList<int>>();
            for (int i = 0; i < pid.Count(); i++)
            {
                IList<int> value = new List<int>(new int[] { pid[i] });
                if (!dic.ContainsKey(ppid[i]))
                {
                    dic.Add(ppid[i], value);
                }
                else
                {
                    dic[ppid[i]].Add(pid[i]);
                }
            }
            //dps(kill, dic,answer);
            stack(kill, dic, answer);
            return answer;
        }

        static void dps(int kill, Dictionary<int, IList<int>> dic, IList<int> answer)
        {
            answer.Add(kill);
            if (!dic.ContainsKey(kill)) return;
            else
            {
                IList<int> subNodes = dic[kill];
                foreach (int node in subNodes)
                {
                    kill = node;
                    dps(kill, dic, answer);
                }
            }
        }

        static void stack(int kill, Dictionary<int, IList<int>> dic, IList<int> answer)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(kill);
            while (stack.Any())
            {
                int pop = stack.Pop();
                answer.Add(pop);
                if (dic.ContainsKey(pop))
                { 
                    foreach(int node in dic[pop])
                    {
                        stack.Push(node);
                    }
                }
            }
        }
    }
}
