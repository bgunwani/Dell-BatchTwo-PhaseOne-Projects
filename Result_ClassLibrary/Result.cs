using System;
using Sport_ClassLibrary;

namespace Result_ClassLibrary
{
    public class Result : Sport
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

}
