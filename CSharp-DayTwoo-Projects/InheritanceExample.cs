using System;
using Result_ClassLibrary;

namespace CSharp_DayTwoo_Projects
{  
    class MainEntry
    {
        static void Main(string[] args)
        {
            Result obj = new Result();
            obj.GetDetails();
            Console.WriteLine("*********************");
            obj.ShowDetails();
            obj.Calculate();

            Console.ReadKey();
        }
    }
}
