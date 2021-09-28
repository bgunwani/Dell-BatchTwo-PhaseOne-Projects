using System;
using Student_ClassLibrary;

namespace Marks_ClassLIbrary
{
    public class Marks : Student
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

}
