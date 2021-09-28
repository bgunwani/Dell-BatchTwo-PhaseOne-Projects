using System;

namespace Student_ClassLibrary
{
    public class Student
    {
        // fields (data members)
        int StudentId;
        string StudentName;
        string StudentAddress;

        // methods (member functions)
        protected void GetDetails()
        {
            Console.Write("Enter Student Id : ");
            this.StudentId = int.Parse(Console.ReadLine());
            Console.Write("Enter Student Name : ");
            this.StudentName = Console.ReadLine();
            Console.Write("Enter Student Address : ");
            this.StudentAddress = Console.ReadLine();
        }
        protected void ShowDetails()
        {
            Console.WriteLine("Student Details : ");
            Console.WriteLine("Student Id : {0}", this.StudentId);
            Console.WriteLine("Student Name : {0}", this.StudentName);
            Console.WriteLine("Student Address : {0}", this.StudentAddress);
        }
        static void Main(string[] args)
        { 
        }
    }
}
