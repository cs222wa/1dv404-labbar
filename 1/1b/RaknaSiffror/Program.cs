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

            string newString = Console.ReadLine(); //Recieve input from user

            //List<int> input = new List<int>(newString.Length);
            List<int> oddList = new List<int>();
            List<int> evenList = new List<int>();
            List<int> zeroList = new List<int>();

            //Convert characters to int 
            int value = int.Parse(newString);

            foreach (char c in newString)   
            {
                


                //Add the characters to list based on if they are even or odd.
                //        if (IsOdd(input[i]))
                //        {
                //            //Add to oddList
                //        }
                //        if (!IsOdd(input[i]))
                //        {
                //            Add to evenList
                //        }
                //         if (input[i] == 0)
                //        {
                //            Add to zeroList
                //        }
            }

            Console.WriteLine(); //Write out the length of the list for odd numbers.
            Console.WriteLine(); //Write out the length of the list for even numbers.


            //   }
            //    public static bool IsOdd(int value)
            //    {
            //    return value % 2 != 0;
            //    }

        }
    }
}
