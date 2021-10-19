/*using System;

namespace DataStructuresImplmentation
{
    class Calculation
    {
        public static int fibonaccci(int number)
        {
            // 1, 2, 3, 5, 8, 13 and so on.
            // O(2^n) - Exponential Notation
            // Used in recursive calculation.
            if (number <= 1) 
                return number;
            return fibonaccci(number - 2) + fibonaccci(number - 1);
        }
    }
    class BigONotationExample
    {
        static void Main(string[] args)
        {
            int result = Calculation.fibonaccci(5);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
*/