using System;

namespace CSharp_DayTwoo_Projects
{

    class Student
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
    }

    class Marks : Student
    {
        protected float ObjectiveMarks, SubjectiveMarks;
        protected new void GetDetails()
        {
            base.GetDetails();
            Console.Write("Enter Objective Marks : ");
            this.ObjectiveMarks = float.Parse(Console.ReadLine());
            Console.Write("Enter Subjective Marks : ");
            this.SubjectiveMarks = float.Parse(Console.ReadLine());
        }
        protected new void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine("Objective Marks : {0}", this.ObjectiveMarks);
            Console.WriteLine("Subjective Marks : {0}", this.SubjectiveMarks);
        }
    }

    class Sport: Marks
    {
        protected float score;
        public new void GetDetails()
        {
            base.GetDetails();
            Console.Write("Enter Score : ");
            this.score = float.Parse(Console.ReadLine());
        }
        public new void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine("Score Obtained : {0}", this.score);
        }
    }

    class Result: Sport
    {
        float TotalMarks, AverageMarks;
        public void Calculate()
        {
            this.TotalMarks = this.ObjectiveMarks + this.SubjectiveMarks + this.score;
            this.AverageMarks = this.TotalMarks / 3;
            Console.WriteLine("Total Marks : " + this.TotalMarks);
            Console.WriteLine("Average Marks : " + this.AverageMarks);
        }
    }

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
