/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresImplmentation
{
    class StringReverser
    {
        public static string reverse(string input)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char ch in input.ToCharArray())
                stack.Push(ch);

            string reversed = "";
            while(stack.Count() != 0)
            {
                reversed += stack.Pop();
            }
            return reversed;
        }
    }
    class ReverseStringUsingStackExample
    {
        static void Main(string[] args)
        {
            String input = "abcd";
            // Output: dcba
            string result = StringReverser.reverse(input);
            Console.WriteLine("Original String : " + input);
            Console.WriteLine("Reversed String : " + result);
            Console.ReadKey();
        }
    }
}
*/