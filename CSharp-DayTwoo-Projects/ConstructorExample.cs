/*using System;

namespace CSharp_DayTwoo_Projects
{

    class Student
    {
        // fields (instance data members)
        int StudentId;
        string StudentName;
        string StudentAddress;
        // static data member
        static string UniversityName;
        static string ApplicationVersion;
        static string ApplicationName;

        // Constructors:
        // Static Constructor
        static Student()
        {
            UniversityName = "Amity University";
            ApplicationVersion = "v001";
            ApplicationName = "Student Management System";
        }
        // Default Constructor
        public Student()
        {
            this.StudentId = 1000;
            this.StudentName = "Shiv Prasad";
            this.StudentAddress = "Chennai";
        }

        // Parameterized Constructor
        public Student(int StudentId, string StudentName, string StudentAddress)
        {
            this.StudentId = StudentId;
            this.StudentName = StudentName;
            this.StudentAddress = StudentAddress;
        }
        // Copy Constructor
        public Student(Student student)
        {
            this.StudentId = student.StudentId;
            this.StudentName = student.StudentName;
            this.StudentAddress = student.StudentAddress;
        }
        // methods (member functions)
        public static void ShowApplicationDetails()
        {
            Console.WriteLine("Application Version : {0}", ApplicationVersion);
            Console.WriteLine("Application Name : {0}", ApplicationName);
        }
        public void ShowDetails()
        {
            Console.WriteLine("Student Details : ");
            Console.WriteLine("Student Id : {0}", this.StudentId);
            Console.WriteLine("Student Name : {0}", this.StudentName);
            Console.WriteLine("Student Address : {0}", this.StudentAddress);
            Console.WriteLine("University Name : {0}", UniversityName);
        }
    }

    class MainEntry
    {
        static void Main(string[] args)
        {
            Student.ShowApplicationDetails();

            Student student1 = new Student();
            student1.ShowDetails();

            Console.WriteLine("*********************");

            Student student2 = new Student(1002, "Bhawna Gunwani", "Delhi");
            student2.ShowDetails();

            Console.WriteLine("*********************");

            // Student student3 = student2; Wrong Practice
            Student student3 = new Student(student2);
            student3.ShowDetails();

            Console.ReadKey();
        }
    }
}
*/