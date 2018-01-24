using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);
            stack.Push(50);
            stack.Push(60);


            Console.WriteLine(stack.Peek());
            int c = stack.Count;

            for (int i = 0; i < c; i++)
            {

               
                Console.WriteLine(stack.Pop());
            }

            if (stack.Count > 0)
            {
                stack.Pop();
            }
            else
                Console.WriteLine("Stacck Emptied");


            Queue<int> queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);
            queue.Enqueue(50);
            queue.Enqueue(60);

            int d = queue.Count;

            for (int i = 0; i < d; i++)
            {
                Console.WriteLine(queue.Dequeue());
            }

            if (stack.Count > 0)
            {
                queue.Dequeue();
            }
            else
                Console.WriteLine("qUEUE Emptied");


        }
    }
}
