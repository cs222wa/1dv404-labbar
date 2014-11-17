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
            int repetition = 1;
            int amount;

            while (true)
            {
                try
                {
                    Console.WriteLine("Hur många heltal vill du mata in?");
                    amount = int.Parse(Console.ReadLine());
                    Console.WriteLine("-------------------------");
                    break;
                }
                catch (FormatException)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Du måste ange ett heltal med siffror.");
                    Console.ResetColor();
                }
            }
            Console.WriteLine("Var god ange dina heltal.");
            Console.WriteLine();
    
            for (int i = 0; i < amount; i++)
            {
                while (true)
                {
                    try
                    {
                        Console.Write("Heltal {0}: ", repetition);
                        int input = int.Parse(Console.ReadLine());
                        repetition++;
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Du måste ange dina heltal med siffror.");
                        Console.ResetColor();
                    }
                } 
            }
            
        }
    }
}
