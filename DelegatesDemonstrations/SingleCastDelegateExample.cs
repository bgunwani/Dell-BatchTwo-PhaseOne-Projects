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
            //Calculation calculation = new Calculation();
            //myDelegate myDel1 = new myDelegate(calculation.Add);
            //myDel1(100, 20);
            //myDelegate myDel2 = new myDelegate(calculation.Subtract);
            //myDel2(100, 20);
            //myDelegate myDel3 = new myDelegate(calculation.Multiply);
            //myDel3(100, 20);
            //myDelegate myDel4 = new myDelegate(calculation.Divide);
            //myDel4(100, 20);

            // Single Cast Delegate (Way Two):
            Calculation calculation = new Calculation();
            myDelegate myDel1 = new myDelegate(calculation.Add);
            myDel1(100, 20);
            myDel1 = new myDelegate(calculation.Subtract);
            myDel1(100, 20);
            myDel1 = new myDelegate(calculation.Multiply);
            myDel1(100, 20);
            myDel1 = new myDelegate(calculation.Divide);
            myDel1(100, 20);
            Console.ReadKey();
        }
    }
}
*/