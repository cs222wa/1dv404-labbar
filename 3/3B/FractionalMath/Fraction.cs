using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionalMath
{
    /// <summary>
    ///Skapa en klass Fraction som representerar ett bråktal på formen T/N där T (täljaren) och 
    ///N (nämnaren) är heltal. Om nämnaren är noll skall ett felmeddelande lämnas. Det skall 
    ///finnas följande medlemmar i klassen. 
    ///• En konstruktor som skapar och initialiserar ett nytt bråktal. 
    ///• Metoderna getNumerator och getDenominator som returnerar täljaren 
    ///respektive nämnaren. 
    ///• Metoden isNegative som ger true om det är ett negativt bråktal. 
    ///• Metoderna add och multiply som utför motsvarande bråktalsoperation på två 
    ///bråk och som returnerar ett nytt bråktal. Bestäm själv ett lämpligt sätt att hantera de 
    ///fall där någon av de inblandade bråktalen har noll i nämnaren. 
    ///• isEqualTo som jämför två Fraction-instanser och ser om de representerar samma 
    ///bråktal. 
    ///• toString som returnerar en strängrepresentation av bråktalet på form T/N. 
    ///Lägg gärna till fler metoder om ni tycker att något fattas. Lämpliga argument- och returtyper 
    ///för de olika metoderna får ni bestämma själva.
    /// </summary>
    class Fraction
    {
        private int _numerator;
        private int _denominator;

        /// <summary>
        ///Metod getNumerator returnerar täljare som ska  vara ett heltal
        /// </summary>
        public int getNumerator
        {
            get { return _numerator; }
            set { _numerator = value; }
        }
        /// <summary>
        ///Metod getDenominator returnerar nämnare som ska vara ett heltal
        /// </summary>
        public int getDenominator
        {
            get { return _denominator; }
            set { _denominator = value; } 
        }
        /// <summary>
        ///Konstruktor som skapar och initialiserar ett nytt bråktal.
        /// </summary>
        /// <param name="numerator"></param>
        /// <param name="denominator"></param>
        public Fraction(int numerator, int denominator) 
        {
            getNumerator = numerator;
            getDenominator = denominator;

            if (getDenominator == 0) //Om nämnaren är noll ska ett felmeddelande lämnas.
            {
                throw new FormatException("Din nämnare får inte ha värdet 0. Försök igen.");
            }
        }
        /// <summary>
        ///Metoden add  utför bråktalsoperation på två bråk och returnerar ett nytt bråktal.
        ///Bestäm själv ett lämpligt sätt att hantera de 
        ///fall där någon av de inblandade bråktalen har noll i nämnaren. 
        /// </summary>
        /// <param name="one"></param>
        /// <param name="two"></param>
        /// <returns></returns>
        public static Fraction operator +(Fraction one, Fraction two)
        {
            return new Fraction(one.getNumerator * two.getDenominator + two.getNumerator * one.getDenominator,
               one.getDenominator * two.getDenominator);
        }
        /// <summary>
        ///Metoden multiply utför bråktalsoperation på två bråk och returnerar ett nytt bråktal.
        ///Bestäm själv ett lämpligt sätt att hantera de 
        ///fall där någon av de inblandade bråktalen har noll i nämnaren. 
        /// </summary>
        /// <param name="one"></param>
        /// <param name="two"></param>
        /// <returns></returns>
        public static Fraction operator *(Fraction one, Fraction two)
        {
            return new Fraction(one.getNumerator * two.getNumerator, one.getDenominator * two.getDenominator);
        }
        /// <summary>
        ///Metoden isNegative returnerar true om det är ett negativt bråktal
        /// </summary>
        /// <returns></returns>
        public bool isNegative()
        {
            if (0 > getDenominator || getNumerator < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        ///isEqualTo som jämför två Fraction-instanser och ser om de representerar samma 
        ///bråktal. 
        /// </summary>
        /// <param name="one"></param>
        /// <param name="two"></param>
        /// <returns></returns>
        public bool isEqual(Fraction a, Fraction b)
        {
            if ((decimal)a.getNumerator/a.getDenominator == (decimal)b.getNumerator/b.getDenominator)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// toString som returnerar en strängrepresentation av bråktalet på form Täljare/Nämnare. 
        /// </summary>
        /// <returns></returns>
        public string toString()
        {
            return string.Format("{0}/{1}", getNumerator, getDenominator);
        }
    }
}
