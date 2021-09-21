/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DayOne_Projects
{
    class ConditionsExample
    {
        static void Main(string[] args)
        {
            *//* Demonstration 1: */
            /*int sellingPrice = 200, costPrice = 200;
            if (sellingPrice > costPrice)
                Console.WriteLine("Profit");
            if (costPrice > sellingPrice)
                Console.WriteLine("Loss");
            if (costPrice == sellingPrice)
                Console.WriteLine("No Profit No Loss");*/

            /* Demonstration 2: */
            /*int sellingPrice = 220, costPrice = 200;
            if (sellingPrice > costPrice)
                Console.WriteLine("Profit");
            else if (costPrice > sellingPrice)
                Console.WriteLine("Loss");
            else
                Console.WriteLine("No Profit No Loss");*/

            /* Demonstration 3: Nested Conditions or Nested If..Else */
            /* A user is only allowed to make a purchase when he is 
             * loggedIn, Email Verified and CardInfo is valid. */
            /*bool isLoggedIn = true;
            bool isEmailVerified = true;
            bool cardInfo = true;
            if (isLoggedIn)
            {
                Console.WriteLine("You are logged in.");
                if(isEmailVerified)
                {
                    Console.WriteLine("Your Email is verified.");
                    if (cardInfo)
                    {
                        Console.WriteLine("You card information is valid.");
                        Console.WriteLine("You can make a purchase.");
                    }
                    else
                    {
                        Console.WriteLine("You cannot make a purchase.");
                    }
                }
                else
                {
                    Console.WriteLine("You cannot make a purchase.");
                }
            }
            else
            {
                Console.WriteLine("You cannot make a purchase.");
            }*/

            /* Demonstration 4: If..Else or Using Logical Operators */
            /* A user is only allowed to make a purchase when he is 
             * loggedIn, Email Verified and CardInfo is valid. */
            /*bool isLoggedIn = true;
            bool isEmailVerified = true;
            bool cardInfo = true;
            if(isLoggedIn && isEmailVerified && cardInfo)
                Console.WriteLine("You can make an purchase.");
            else
                Console.WriteLine("You cannot make an purchase.");*/

            /* Demonstration 5: If..Else or Using Logical Operators */
            /* Allow a user to access course if he is:
             * logged in from email, logged in from Google or logged in from Facebook. */
            /*bool email = false;
            bool facebook = false;
            bool google = false;
            if (email || facebook || google)
                Console.WriteLine("Login Successful.");
            else
                Console.WriteLine("Login Failed.");*/

            /* Demonstration 6: If..Else or Turnery/Conditional Operator */
            /* Show User a signout button if he is authenticated,
             * Otherwise, show him option to login/signup. */
            /*bool isAuthenticated = false;
            if (isAuthenticated)
                Console.WriteLine("Show Signout Button");
            else
                Console.WriteLine("Show SignIn/SignUp Button");
            var result = isAuthenticated ? "Show Signout Button" : "Show SignIn/SignUp Button";
            Console.WriteLine(result);*//*



        }
    }
}
*/