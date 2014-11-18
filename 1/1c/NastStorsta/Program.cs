using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NastStorsta
{
    class Program
    {
        /// <summary>
        /// Uppgift 1c
        /// Skriv ett program NastStorsta som läser in tio heltal och hittar det näst största talet av 
        /// dem och därefter skriver ut det. En körning kan se ut enligt följande: 
        /// Mata in 10 heltal: 67 -468 36 1345 -7778 0 34 7654 45 -666 
        /// Det näst största talet är: 1345 
        /// Försök att göra programmet så att det är lätt att ändra antalet inmatade heltal.  -/
        /// Rekommendation: Använd färre än 10 heltal under tiden ni utvecklar programmet.
        /// Notera: Du får inte använda arrayer (eller andra datastrukturer) i den här uppgiften.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int amount;                         //Variable for the amount of numbers the user want to calculate.
            int input;                          //Variable for the users input of numbers.
            int greatestNumber = int.MinValue;      //Value for Greatest & secondGreatest number set to minimum value for an integer.
            int secondGreatestNumber = int.MinValue;
            while (true)
            {
                try
                {
                    Console.WriteLine("Hur många heltal vill du mata in?");
                    amount = int.Parse(Console.ReadLine());         //The amount of numbers to be inserted is set by user.
                    Console.WriteLine("-------------------------");
                    break;
                }
                catch (FormatException)     //If an error occurs a message will be displayed.
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Du måste ange ett heltal med siffror.");
                    Console.ResetColor();
                }
            }
            Console.WriteLine("Var god ange dina heltal.");
            Console.WriteLine();
            for (int i = 0; i < amount; i++)    //Loops through the numbers inserted by user.
            {
                while (true)
                    try
                    {
                        input = int.Parse(Console.ReadLine());      //Value for input (numbers) is set by user.
                        break;
                    }
                    catch (Exception)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;     //If input is faulty a message will be displayed.
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Det angivna talet kan inte tolkas som ett heltal.");
                        Console.ResetColor();
                    }
                if (input > greatestNumber)        //If the input value is greater than the value of the current greatest number...
                {
                    secondGreatestNumber = greatestNumber;  //... the value of the current greatest number will be redirected to be the second greatest number.
                    greatestNumber = input;                 //and the user input value will be set as the greatest number.
                }
                else if (input > secondGreatestNumber)      //If the input is bigger than the second greatest number, but NOT bigger than the greatest number
                {                                           //its value will be replaced by the value of input.
                    secondGreatestNumber = input;
                }
            }
            Console.WriteLine("Det näst största talet är {0}.", secondGreatestNumber);      //the second greatest number will be presented.
        }
    }
}




