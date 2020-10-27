using System;
using System.Linq.Expressions;

namespace SwitchStatementExcercise
{
    class Program
    {

        /*
        Ask the user for their favorite school subject.  
        Store their answer in a variable
        Pass the variable as the expression in a switch statement.
        Create 5 different cases for different subjects.  Each case will print the subject chosen and a custom message of your choosing.
        Create a default case to handle any case not handled.
        asdkawertkawerktbakwekawekvrkawervkawkervkawekrvkawekrvkawerkakwvkrawkvr
         */
        static void Main(string[] args)
        {

            Console.WriteLine("What is your favorite school subject");
         
            var userResponse = Console.ReadLine();

            switch (userResponse)

            {

                case "English":
                    Console.WriteLine($"Not a fan but its important");
                    break;

                case "Math":

                    Console.WriteLine($"I rather be a stripper");
                    break;

                case "Science":

                    Console.WriteLine($" God vs science? Good subject!!");
                    break;

                case "History":

                    Console.WriteLine($" Culture culture cultre!");
                    break;

                default:
                    Console.WriteLine("I am bored");
                    break;
            }
            
              
        }
    }
}
