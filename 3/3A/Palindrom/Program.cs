using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom
{
    /// <summary>
    /// Skriv ett program Palindrom som testar om en textrad (läses in från tangentbordet, enbart 
    ///små bokstäver) är ett palindrom, dvs, att textraden har samma sekvens av bokstäver vare sig 
    ///man läser den framifrån eller bakifrån. Ge några exempel som testar funktionaliteten.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string inputWord = "";
            string reverseWord = "";
            while (true)
            {
                try
                {
                    Console.Write("Ange ordet du vill testa med små bokstäver: ");
                    inputWord = Console.ReadLine();     //Tar emot ord ifrån användaren
                    if (inputWord == "")
                    {
                        throw new FormatException();       //Om användaren inte skriver något så kastas ett undantag.
                    }
                    foreach (char c in inputWord)       //Loopa igenom bokstäverna i ordet.
                    {  
                        if (c.ToString() == char.ToUpper(c).ToString())     //Om ordet innehåller versaler så kastas ett undantag
                        {
                            throw new FormatException();
                        }
                    }
                    break;
                }
                catch (FormatException)         //När ett undantag kastas visas ett felmeddelande.
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Det du skrev kunde inte tolkas som ett ord. Försök igen.");
                    Console.ResetColor();
                }
            }
            for(int i=inputWord.Length -1; i>=0; i--){ //Loopar igenom strängen baklänges
                reverseWord += inputWord[i].ToString(); //Spara den nya ordningen av bokstäver till en sträng
            }
            if (reverseWord == inputWord) //Om de båda strängarna ser likadana ut, så visas ett meddelande.
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Ditt ord är ett palindrom. {0} blir även {1} baklänges.", inputWord, reverseWord);
                Console.ResetColor();
            }
            else //Om de båda strängarna INTE ser likadana ut, så visas ett annat meddelande.
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Tyvärr är ditt ord inte ett palindrom. {0} blir {1} baklänges.", inputWord, reverseWord);
                Console.ResetColor();
            }
            }
        }
    }

