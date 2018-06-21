using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0621_stack
{
    class Program
    {
        public static void PrintValues(IEnumerable myCollection)
        {
            foreach (string obj in myCollection)
            {
                Console.Write("{0} ", obj);
            }
            Console.WriteLine();
            Console.WriteLine("========");
        }
        static void Main(string[] args)
        {
            Stack<string> myStack = new Stack<string>();
            myStack.Push("5");
            myStack.Push("4");
            myStack.Push("3");
            myStack.Push("2");
            myStack.Push("1");

            Console.WriteLine("Count:{0}", myStack.Count);
            PrintValues(myStack);


            Console.WriteLine("Peek: "+myStack.Peek());

            Console.WriteLine("========");
            Console.WriteLine("Pop: " + myStack.Pop());

            Console.WriteLine("========");
            Console.WriteLine("剩下的: " );
            PrintValues(myStack);


            Stack<string> Stack2 = new Stack<string>(myStack.ToArray());
            PrintValues(Stack2);


        }
    }
}
