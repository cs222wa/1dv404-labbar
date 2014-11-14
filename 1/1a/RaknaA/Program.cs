using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaknaA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Var god ange valfri mening: ");
            string sentence = Console.ReadLine();
            if (sentence == null)
            {
                Console.WriteLine("Du måste skriva något i textfältet.");
            }
            int smallA = TextTool.CharInString(sentence, "A");
            int bigA = TextTool.CharInString(sentence, "a");
            Console.WriteLine("Antal a: {0} \nAntal A: {1}", smallA, bigA);
        }
    }
}
