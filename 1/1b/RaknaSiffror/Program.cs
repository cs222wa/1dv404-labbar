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
            Console.WriteLine("Var god ange ett tal.");
            string newString = Console.ReadLine(); //Recieve input from user
            List<int> oddList = new List<int>();
            List<int> evenList = new List<int>();
            List<int> zeroList = new List<int>();

            for (int i = 0; i < newString.Length; i++)
            {
                if (IsOdd(i))
                {
                    oddList.Add(i);     //Add character to oddList
                }
                if (!IsOdd(i))
                {
                    if (i == 0)
                    {
                        zeroList.Add(i); //Add character to zeroList
                    }
                    else
                    {
                        evenList.Add(i);    //Add character to evenList
                    }
                }
            }
            Console.WriteLine("Antal nollor: {0}", zeroList.Count); //Write out the length of the list for zeroes.
            Console.WriteLine("Antal udda siffor: {0}", oddList.Count); //Write out the length of the list for odd numbers.
            Console.WriteLine("Antal jämna siffor: {0}", evenList.Count); //Write out the length of the list for even numbers.
        }

        public static bool IsOdd(int value)
        {
            return value % 2 != 0;      //return true or false if the character is odd or even.
        }
    }
}



