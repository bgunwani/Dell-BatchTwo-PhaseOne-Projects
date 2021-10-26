/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiscConcepts
{
    class ValuevsReferenceParameterExample
    {
        static (int, int) SwapByValue(int num1, int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
            return (num1, num2);
        }
        static void SwapByReference(ref int num1, ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }
        static void PassByValue(int num)
        {
            num = 100;
        }
        static void PassByReference(ref int num)
        {
            num = 100;
        }

        static void Main(string[] args)
        {
            //int num = 10;
            //PassByValue(num);
            //Console.WriteLine("Number (Main Method) : " + num);
            //Console.WriteLine("***************************");
            //PassByReference(ref num);
            //Console.WriteLine("Number (Main Method) : " + num);
            //Console.WriteLine("***************************");
            //var (num1, num2) = SwapByValue(100, 200);
            //Console.WriteLine($"First Number : {num1}, Second Number : {num2}");
            //Console.WriteLine("***************************");
            int num1 = 100, num2 = 200;
            SwapByReference(ref num1, ref num2);
            Console.WriteLine($"First Number : {num1}, Second Number : {num2}");
            Console.WriteLine("***************************");
            Console.ReadKey();
        }
    }
}
*/