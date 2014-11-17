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
            if (string.IsNullOrEmpty(newString))    //If string is empty an exception will be thrown and a message displayed.
            {
                try
                {
                    throw new ArgumentException(); 
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Du måste ange minst en siffra.");
                    return;
                }
            }

            foreach (char c in newString) //Loops through the characters in the string
            {
                if (Char.IsLetter(c)) //If string contains letters an exception will be thrown and a message displayed.
                {
                    try
                    {
                        throw new ArgumentException();
                    }
                    catch (ArgumentException)
                    {
                        Console.WriteLine("Raden måste bestå av siffror.");
                        return;
                    }
                }
            }
            List<int> oddList = new List<int>();
            List<int> evenList = new List<int>();
            List<int> zeroList = new List<int>();
            for (int i = 0; i < newString.Length; i++)  //Loops through the content of the string
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



