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
            Console.WriteLine("Var god ange 10 siffror.");

            int[] input = new int[10]; // Tar emot siffror frn användare
            for (int i = 0; i < 10; i++)
            {
                input[i] = int.Parse(Console.ReadLine());
                if (IsOdd(input[i]))
                {
                    Console.WriteLine("Siffran {0} är ojämn", input[i]);
                }
                if (!IsOdd(input[i]))
                {
                    Console.WriteLine("Siffran {0} är jämn", input[i]);
                }
            }
        }
            public static bool IsOdd(int value)
            {
	        return value % 2 != 0;
            }
            

            //int odd;
            //int even;

            //if (isOdd(input)) ;      //Om siffran är ojämn skriv ut antalet
            //{
            //}
            //if (!isOdd(input)) ;    //Om siffran är jämn skriv ut antalet
            //{
            //}




            // kriv ett program RaknaSiffror som för ett godtyckligt positivt heltal N (läses in från 
            // tangentbordet) skriver ut antalet nollor, antalet udda siffror och antalet jämna siffror. En 
            // körning kan se ut enligt följande: 
            // Mata in ett heltal: 6789500 Nollor: 2 Udda: 3 Jämna: 2
        }
    }

