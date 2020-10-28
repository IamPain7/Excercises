using System;
using System.Diagnostics;

namespace VariablesExcercise
{

    /*
        Step 1: Declare and initialize variables for the following types: 
        string 
        int 
        char 
        bool 
        double
        decimal 


        Step 2: Concatenate these variables in a Console.Writeline();
        For example:
        string dogName = "Ralph";
        int dogAge = 10;    
        Console.WriteLine($"My dog's name is {dogName}, He is {dogAge} years old"



        Step 3: Analyze any errors you might incur, if any, and research how to fix it. This is a prime opportunity to exemplify self-learning.


     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");

            String name = Console.ReadLine();
            Console.WriteLine($"Hello {name}"!);

            Console.WriteLine("How old are you?");
            int myAge = int.Parse(Console.ReadLine());
            Console.WriteLine($"{myAge} looks young to me!");

            Console.WriteLine("What is your favorite Char?");
            char favChar = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Are you married? Only asnwer True or False");
            var isMarreid = Console.ReadLine();
            bool isResult = Convert.ToBoolean(isMarreid);
           

            if (isResult==true)
            {

                Console.WriteLine($"Oh ok");



            }

            else
            {

                Console.WriteLine("So are you single");
                

            }
        


          


            Console.WriteLine("what is your favorite numbers?");
            double myNumbers = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("What is your favor decimal numbers?");
            decimal myDec = Convert.ToDecimal(Console.ReadLine());
          

        

            

         
            
        }
    }
}
