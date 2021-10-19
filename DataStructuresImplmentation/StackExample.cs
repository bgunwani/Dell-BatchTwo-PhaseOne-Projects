/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresImplmentation
{
    class StackExample
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();

            stack.Push("King");
            stack.Push("Kochhar");
            stack.Push("John");
            stack.Push("Smith");

            foreach (object item in stack)
                Console.WriteLine(item);

            Console.WriteLine("***********************************");

            Console.WriteLine("Element Popped out : " + stack.Pop());

            Console.WriteLine("***********************************");

            foreach (object item in stack)
                Console.WriteLine(item);

            Console.WriteLine("***********************************");

            Console.WriteLine("Element Ready to Pop : " + stack.Peek());
            Console.WriteLine("Element Popped out : " + stack.Pop());

            Console.WriteLine("***********************************");

            foreach (object item in stack)
                Console.WriteLine(item);

            Console.WriteLine("***********************************");

            if (stack.Count == 0)
                Console.WriteLine("Stack is Empty");
            else
                Console.WriteLine("Stack is not Empty.");
            

            Console.ReadKey();
        }
    }
}
*/