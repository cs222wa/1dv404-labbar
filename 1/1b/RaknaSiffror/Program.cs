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
            int newString;
            string number;
            while (true)
            {
                try
                {
                    Console.Write("Var god ange ett tal att behandla: ");
                    newString = int.Parse(Console.ReadLine()); //Recieve input from user
                    break;
                }
                catch (FormatException)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Du måste ange minst en siffra.");
                    Console.ResetColor();
                }
            }
            number = newString.ToString();
            List<int> oddList = new List<int>();
            List<int> evenList = new List<int>();
            List<int> zeroList = new List<int>();
            
            foreach (char c in number)  //Loops through the content of the string
            {
                if (IsOdd(c))
                {
                    oddList.Add(c);     //Add character to oddList
                }
                if (!IsOdd(c))
                {
                    if (c == '0')
                    {
                        zeroList.Add(c); //Add character to zeroList
                    }
                    else { 
                    evenList.Add(c);    //Add character to evenList 
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



