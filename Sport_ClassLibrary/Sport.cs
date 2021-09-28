using System;
using Marks_ClassLIbrary;

namespace Sport_ClassLibrary
{
    public class Sport : Marks
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
}
