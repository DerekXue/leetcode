using System;
using System.Collections.Generic;

namespace ConsoleApp56
{
    class MovingAverage
    {
        static void Main(string[] args)
        {
            MovingAverage xue = new MovingAverage(3);
            xue.Next(4);
            xue.Next(1);
            xue.Next(1);
            double answer =xue.Next(4);
            
            Console.WriteLine(answer);
            Console.ReadKey();
        }
    }

    public class MovingAverage
    {

        private Queue<int> queue;
        private int size;

        /** Initialize your data structure here. */
        public MovingAverage(int size)
        {
            queue = new Queue<int>(size);
            this.size = size;
        }

        public double Next(int val)
        {
            double answer = 0;
           
            if (queue.Count!=0)
            {
                if(queue.Count == this.size)
                {
                    queue.Dequeue();
                }
                queue.Enqueue(val);
                double sum = 0;
                foreach (var i in queue)
                {
                    sum += i;
                }
                answer = sum / queue.Count;
                return answer;
            }
            else
            {
                queue.Enqueue(val);
                return val;
            }
        }
    }
}
