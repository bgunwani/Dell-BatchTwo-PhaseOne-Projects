/*using System;

namespace CSharp_DayOne_Projects
{
    class InputOutputExample
    {
        static void Main(string[] args)
        {
            string empName;
            int empCode;
            float empSalary;
            double empContact;
            char empGender;
            bool isFresher;

            Console.Write("Enter Employee Name : ");
            empName = Console.ReadLine();
            Console.Write("Enter Employee Code : ");
            *//*empCode = Convert.ToInt32(Console.ReadLine());*//*
            empCode = int.Parse(Console.ReadLine());
            Console.Write("Enter Employee Salary : ");
            *//*empSalary = Convert.ToSingle(Console.ReadLine());*//*
            empSalary = float.Parse(Console.ReadLine());
            Console.Write("Enter Employee Contact : ");
            *//*empContact = Convert.ToDouble(Console.ReadLine());*//*
            empContact = double.Parse(Console.ReadLine());
            Console.Write("Enter Employee Gender (M/F) : ");
            *//*empGender = Convert.ToChar(Console.ReadLine());*//*
            empGender = char.Parse(Console.ReadLine());
            Console.Write("Are you freasher? (true/false) : ");
            *//*isFresher = Convert.ToBoolean(Console.ReadLine());*//*
            isFresher = bool.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Employee Name : " + empName);
            Console.WriteLine("Employee Code : " + empCode);
            Console.WriteLine("Employee Salary : " + empSalary);
            Console.WriteLine("Employee Contact : " + empContact);
            Console.WriteLine("Employee Gender : " + empGender);
            Console.WriteLine("Are you fresher ? " + isFresher);
            Console.WriteLine(isFresher ? "Yes, I am Fresher." : "No, I am experienced.");
            Console.ReadKey();
        }
    }
}
*/