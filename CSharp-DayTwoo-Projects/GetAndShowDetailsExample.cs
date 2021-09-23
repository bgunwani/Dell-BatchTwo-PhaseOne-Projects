/*using System;

namespace CSharp_DayTwoo_Projects
{

    class Student
    {
        // fields (data members)
        int StudentId;
        string StudentName;
        string StudentAddress;

        // methods (member functions)
        public void GetDetails()
        {
            Console.Write("Enter Student Id : ");
            this.StudentId = int.Parse(Console.ReadLine());
            Console.Write("Enter Student Name : ");
            this.StudentName = Console.ReadLine();
            Console.Write("Enter Student Address : ");
            this.StudentAddress = Console.ReadLine();
        }
        public void ShowDetails()
        {
            Console.WriteLine("Student Details : ");
            Console.WriteLine("Student Id : {0}", this.StudentId);
            Console.WriteLine("Student Name : {0}", this.StudentName);
            Console.WriteLine("Student Address : {0}", this.StudentAddress);
        }
    }

    class MainEntry
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.GetDetails();
            student1.ShowDetails();

            Console.WriteLine("*********************");

            Student student2 = new Student();
            student2.GetDetails();
            student2.ShowDetails();

            Console.ReadKey();
        }
    }
}
*/