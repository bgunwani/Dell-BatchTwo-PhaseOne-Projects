/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DayFour_Projects
{
    class PriceException: Exception
    {
        public PriceException(): base("Invalid Price Entered.") { }
        public PriceException(string message): base(message) { }
    }


    class ExceptionExampleThree
    {
        static void Main(string[] args)
        {
            float sellingPrice, costPrice;
            try
            {
                Console.Write("Enter Selling Price : ");
                sellingPrice = int.Parse(Console.ReadLine());
                Console.Write("Enter Cost Price : ");
                costPrice = int.Parse(Console.ReadLine());
                if (sellingPrice >= 0)
                {
                    if (costPrice >= 0)
                    {
                        if (sellingPrice > costPrice)
                        {
                            Console.WriteLine("Profit Occurred.");
                        }
                        else if (costPrice > sellingPrice)
                        {
                            Console.WriteLine("Loss Occurred.");
                        }
                        else
                        {
                            Console.WriteLine("No Profit No Loss");
                        }
                    }
                    else
                    {
                        //Console.WriteLine("Cost Price/Selling Price cannot be zero.");
                        //throw new PriceException("Cost Price/Selling Price cannot be zero.");
                        throw new PriceException();
                    }
                }
                else
                {
                    //Console.WriteLine("Cost Price/Selling Price cannot be zero.");
                    //throw new PriceException("Cost Price/Selling Price cannot be zero.");
                    throw new PriceException();
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(PriceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
*/