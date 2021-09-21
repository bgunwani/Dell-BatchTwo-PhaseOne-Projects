using System;

namespace CSharp_DayOne_Projects
{
    class LoopingConstructExample
    {
        static void Main(string[] args)
        {
            // For Loop
            // While Loop
            // Do While Loop
            // Foreach Loop

            // For Loop
            //for(int i= 0; i <= 10; i++)
            //{
            //    if (i % 2 == 0)
            //        Console.WriteLine(i);
            //    else
            //        continue;
            //}

            // While Loop
            //bool needMoreCandies = true;
            //int candiesCount = 0;
            //while(needMoreCandies)
            //{
            //    Console.WriteLine("Do you need one more Candy ? ");
            //    string answer = Console.ReadLine();
            //    if (answer == "yes" || answer == "Yes" || answer == "YES")
            //        candiesCount++;
            //    else
            //        needMoreCandies = false;
            //}
            //Console.WriteLine("Candies Count : " + candiesCount);

            // Do While Loop
            /*string answer;
            int candiesCount = 0;
            do
            {
                candiesCount++;
                Console.WriteLine("Do you need one more Candy ? ");
                answer = Console.ReadLine();
            }
            while (answer == "yes" || answer == "Yes" || answer == "YES");
            Console.WriteLine("Candies Count : " + candiesCount);*/

            string choice; 
            do
            {
                Console.WriteLine("Enter your Question ?");
                var question = Console.ReadLine();
                switch (question)
                {
                    case "Do you love C#?":
                        Console.WriteLine("Yes, I am in love with programming language.");
                        break;

                    case "How do I look today?":
                    case "Would you like to praise about me?":
                        Console.WriteLine("You look awesome.");
                        break;

                    default:
                        Console.WriteLine("I have no clue what you are talking about.");
                        break;
                }
                Console.Write("Do you wish to continue ? (yes/no) : ");
                choice = Console.ReadLine();
            }
            while(choice.ToUpper() == "YES");

            Console.ReadLine();
        }
    }
}
