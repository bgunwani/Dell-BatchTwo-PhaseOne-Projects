/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiscConcepts
{
    class OutParameterExample
    {
        static void GetCustomerDetails(out string CustomerName, out int CustomerAge, out double CustomerAmount)
        {
            CustomerName = "King Kochhar";
            CustomerAge = 45;
            CustomerAmount = 12000;
        }
        static void Main(string[] args)
        {
            // Declarations
            // string CustomerName;
            // int CustomerAge;
            // double CustomerAmount;

            // Method Calling to get data from Database
            // GetCustomerDetails(out string CustomerName, out int CustomerAge, out double CustomerAmount);
            GetCustomerDetails(out string CustomerName, out int CustomerAge, out _);
            
            // Print Details
            //Console.WriteLine($"{CustomerName} : {CustomerAge} : {CustomerAmount}");
            Console.WriteLine($"{CustomerName} : {CustomerAge}");

            Console.ReadKey();
        }

    }
}
*/