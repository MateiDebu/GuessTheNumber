using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    public class GuessNumber
    {
        private int number;
        public GuessNumber()
        {
            Random random = new Random();
            number = random.Next(0, 100);
        }
        public void Guess()
        {
            Console.WriteLine("Insert the number which you think is correct. The number must be between 0 and 100:");
            int guessNumber;

            do
            {
                string str = Console.ReadLine();
                guessNumber = int.Parse(str);

                if (guessNumber < number)
                {
                    Console.WriteLine("The number was to small! Insert the new number: ");
                }
                else
                if (guessNumber > number)
                {
                    Console.WriteLine("The number was to big! Insert the new number: ");
                }
                else
                {
                    Console.WriteLine("The number is correct!");
                }
                   
            } while (guessNumber != number);

            Console.WriteLine("The game is over!");
        }
    }
}
