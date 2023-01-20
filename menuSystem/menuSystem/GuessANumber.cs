using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menuSystem
{
    internal class GuessANumber
    {
        public GuessANumber() {

            Console.WriteLine("Välkommen! Jag tänker på ett nummer mellan 1 och 20. Kan du gissa vilket? Du får fem försök.");

            string guessString;
            int i = 0;
            Random random = new Random();
            int number = random.Next(1, 20);
            int numberofGuesses = 5;
            while (i < 5)
            {
                Console.WriteLine("Number of guesses left: " + numberofGuesses);
                Console.WriteLine("Gissa nummer: ");
                guessString = Console.ReadLine();
                int guessInt;
                bool isNumerical = int.TryParse(guessString, out guessInt);
                if (isNumerical == false)
                {
                    Console.WriteLine("Error, you must write a number!");
                    return;
                }
                if (guessInt > 20)
                {
                    Console.WriteLine("Error, number must be between 1 and 20");
                    return;
                }
                if (guessInt > number)
                {
                    Console.WriteLine("Tyvärr du gissade för högt!");
                }
                if (guessInt < number)
                {
                    Console.WriteLine("Tyvärr du gissade för lågt!");
                }
                if (guessInt == number)
                {
                    Console.WriteLine("Woho! Du gjorde det!");
                    break;
                }
                if (numberofGuesses == 1)
                {
                    Console.WriteLine("Tyvärr du lyckades inte gissa talet på fem försök!");
                    break;
                }
                numberofGuesses--;
                i++;
            }



        }
    }
}
