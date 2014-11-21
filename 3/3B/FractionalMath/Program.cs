using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionalMath
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Fraction one = new Fraction(3, 4);
                Fraction two = new Fraction(1, 2);
                Fraction three = new Fraction(5, 5);
                Fraction four = new Fraction(2, 2);
                Fraction threeFour = new Fraction(2, 2);
                Fraction five = new Fraction(-2, 6);

                //Fraction six = new Fraction(5, 0);  // <--- uncomment to display error message.

                Console.WriteLine("-------------------------");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Add");
                Console.ResetColor();
                Console.WriteLine("{0} + {1} = {2}", one.toString(), two.toString(), (one + two).toString());
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Multiply");
                Console.ResetColor();
                Console.WriteLine("{0} * {1} = {2}", one.toString(), two.toString(), (one * two).toString());
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Is Equal");
                Console.ResetColor();
                Console.WriteLine("Representerar bråktalet {0} samma decimaltal som {1}?", three.toString(), four.toString());
                if (threeFour.isEqual(three, four) == true)
                {
                    Console.WriteLine("Ja, det båda talen representerar samma decimaltal.");
                }
                else
                {
                    Console.WriteLine("Nej, det båda talen representerar inte samma decimaltal.");
                }
                Console.WriteLine();
                Console.WriteLine("Representerar bråktalet {0} samma decimaltal som {1}?", one.toString(), two.toString());
                if (three.isEqual(one, two) == true)
                {
                    Console.WriteLine("Ja, det båda talen representerar samma decimaltal.");
                }
                else
                {
                    Console.WriteLine("Nej, det båda talen representerar inte samma decimaltal.");
                }
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Is Negative");
                Console.ResetColor();
                Console.WriteLine("Betraktas bråktalet {0} som negativt?", five.toString());
                if (five.isNegative() == true)
                {
                    Console.WriteLine("Ja, det aktuella talet betraktas som negativt.");
                }
                else
                {
                    Console.WriteLine("Nej, det aktuella talet betraktas inte som negativt.");
                }
                Console.WriteLine();
                Console.WriteLine("Betraktas bråktalet {0} som negativt?", two.toString());
                if (two.isNegative() == true)
                {
                    Console.WriteLine("Ja, det aktuella talet betraktas som negativt.");
                }
                else
                {
                    Console.WriteLine("Nej, det aktuella talet betraktas inte som negativt.");
                }
                Console.WriteLine();
                Console.WriteLine("-------------------------");
            }
            catch (Exception e)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(e.Message);
                Console.ResetColor();
            }
        }

        private static void negativeMessage()
        {
            throw new NotImplementedException();
        }
    }
}
