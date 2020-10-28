using System;

namespace SyntaxSugarExcercise
{
    class Program
    {


        /*
         * Given the following code, change the code to implement inferred typing, string interpolation, and the ternary operator

         * int answer = 4;
            string response;
            
            if (answer < 9) 
            {
                response = answer + " is less than nine";
                        }
                else
                {
                   response = answer + “greater than or equal to nine”;
                }
                Inferred Typing Sample:
                    
                    Cheat code:
                    var name= "Jj";

                    Explicit typing Sample:
                    string name = "Jj";

                    Inline or ternary operator
                    var answer=(myAge<19)$ " You are 19 years old" : " You are too young";


                    Syntax sugar or string interpolation sample:
                    Console.Writeline($"Hello,{} your pets name {}, and ")

         */
        static void Main(string[] args)
        {

            int answer = 4; //Data type, Variable and Value
            String response = Console.ReadLine();



         var result = (answer < 4) ? "Yes it is less than nine" : " 9 is greater than 4"; //ternary operator

            Console.WriteLine($"The result is {result}"); //string interpolation









        }
    }
}
