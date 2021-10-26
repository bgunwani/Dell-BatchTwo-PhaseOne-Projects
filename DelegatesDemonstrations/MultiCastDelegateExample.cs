/*using System;

namespace DelegatesDemonstrations
{
    public delegate void myDelegate(int x, int y);
    class Calculation
    {
        public void Add(int num1, int num2)
        {
            Console.WriteLine("The sum of two numbers is " + (num1 + num2));
        }
        public void Subtract(int num1, int num2)
        {
            Console.WriteLine("The difference between two numbers is " + (num1 - num2));
        }
        public void Multiply(int num1, int num2)
        {
            Console.WriteLine("The product of two numbers is " + (num1 * num2));
        }
        public void Divide(int num1, int num2)
        {
            Console.WriteLine("The division of two numbers is " + (num1 / num2));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            // Single Cast Delegate (Way One):
            Calculation calculation = new Calculation();
            myDelegate myDel = new myDelegate(calculation.Add);
            myDel(100, 20);
            Console.WriteLine("------------");
            myDel += calculation.Subtract;
            myDel(100, 20);
            Console.WriteLine("------------");
            myDel += calculation.Multiply;
            myDel(100, 20);
            Console.WriteLine("------------");
            myDel += calculation.Divide;
            myDel(100, 20);
            Console.ReadKey();
        }
    }
}
*/