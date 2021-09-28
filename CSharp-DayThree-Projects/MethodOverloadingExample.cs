/*using System;

namespace CSharp_DayThree_Projects
{
    class Calculator
    {
        public int addition(int num1, int num2)
        {
            return num1 + num2;
        }
        public int addition(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }
        public float addition(float num1, float num2)
        {
            return num1 + num2;
        }
        public float addition(int num1, float num2)
        {
            return num1 + num2;
        }
        public float addition(float num1, int num2)
        {
            return num1 + num2;
        }
    }
    class Calculator2 : Calculator
    {
        public string addition(string num1, string num2)
        {
            return num1 + num2;
        }
    }
    class MethodOverloadingExample
    {
        static void Main(string[] args)
        {
            Calculator2 calc = new Calculator2();
            Console.WriteLine(calc.addition(100, 200));
            Console.WriteLine(calc.addition(100.25F, 200.34F));
            Console.WriteLine(calc.addition("Hello", "World"));

        }
    }
}
*/