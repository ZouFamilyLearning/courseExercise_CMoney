using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0621_Queue
{
    class Program
    {
        public static void PrintValues(IEnumerable myCollection)
        {
            foreach (string item in myCollection)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Queue<string> myQueue = new Queue<string>();
            myQueue.Enqueue("5");
            myQueue.Enqueue("4");
            myQueue.Enqueue("3");
            myQueue.Enqueue("2");
            myQueue.Enqueue("1");

            PrintValues(myQueue);
            Console.WriteLine("=====");
            Console.WriteLine("Count: " + myQueue.Count);

            Console.WriteLine("=====");
            Console.WriteLine("Peek: " + myQueue.Peek());

            Console.WriteLine("=====");
            Console.WriteLine("Pop: " + myQueue.Dequeue());

            Console.WriteLine("=====");
            PrintValues(myQueue);

            Console.WriteLine("=====");
            Console.WriteLine(myQueue.ElementAt(1));

            Console.WriteLine("==CopyTo==");
            Queue<string> queueCopy = new Queue<string>(myQueue.ToArray());

            PrintValues(queueCopy);

            Console.WriteLine("queueCopy.Contains(\"5\") = {0}", queueCopy.Contains("5"));
            queueCopy.Clear();
            Console.WriteLine("Clear, so queueCopy.Count = {0}", queueCopy.Count);
        }
    }
}
