using System;

namespace SyntaxSugarExcercise
{
    class Program
    {


        /*
        
                    Cheat code:
                    Inferred Typing Sample:
                    var name= "Jj";

                    Explicit typing Sample:
                    string name = "Jj";

                    Inline or ternary operator
                    var answer=(myAge<19)$ " You are 19 years old" : " You are too young";


                    Syntax sugar or string interpolation sample:
                    Console.Writeline($"Hello,{} your pets name {}, and ")
        ===================================  ===================================  ===================================  ===================================  =================================
                  * Given the following code, change the code to implement inferred typing, string interpolation, and the ternary operator
          
                 *  int answer = 4;
                    string response;
            
                    if (answer < 9) 
                    {
                    response = answer + " is less than nine";
                    }
                     else
                    {
                     response = answer + “greater than or equal to nine”;
                    }


                 */
        static void Main(string[] args)
        {
            //I don't know what I'm doing
            //Mistake you used int
            var answer = 4; //Data type, Variable and Value // Inference typing// Value type
            //You changed string to var 
            var response  = (answer <9) ? $"{answer} is less than nine" : $"9 is greater than {answer}"; //ternary operator

            Console.WriteLine($"{response}"); //string interpolation


          



        }
    }
}
