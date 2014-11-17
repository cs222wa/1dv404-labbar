using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaknaSiffror
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skriv ett program RaknaSiffror som för ett godtyckligt positivt heltal N (läses in från 
            // tangentbordet) skriver ut antalet nollor, antalet udda siffror och antalet jämna siffror. En 
            // körning kan se ut enligt följande: 
            // Mata in ett heltal: 6789500 Nollor: 2 Udda: 3 Jämna: 2

            string input = Console.ReadLine(); //Recieve input from user
            //Create new array for Odd numbers
            //Create new array for even numbers
            //Create new array for zeros

            foreach (char c in input)   
            {
                //Convert characters to int 
                //Add the characters to array based on if they are even or odd.
                //        if (IsOdd(input[i]))
                //        {
                //            //Add to oddArr
                //        }
                //        if (!IsOdd(input[i]))
                //        {
                //            Add to evenArr
                //        }
                //         if (input[i] == 0)
                //        {
                //            Add to zeroArr
                //        }
            }

            Console.WriteLine(); //Write out the length of the array for odd numbers.
            Console.WriteLine(); //Write out the length of the array for even numbers.


            //   }
            //    public static bool IsOdd(int value)
            //    {
            //    return value % 2 != 0;
            //    }

        }
    }
}
