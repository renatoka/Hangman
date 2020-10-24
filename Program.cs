using System;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            string word1;
            Console.Write("Please enter a random word: ");
            word1 = Console.ReadLine();
            word1.ToLower();
            Console.Clear();

            int i = 0;
            int j = 0;
            do
            {
                string guess;
                Console.Write("Please enter a letter: ");
                guess = Console.ReadLine();

                if (guess == "" +
                    "")
                {
                    i += 1;
                    Console.WriteLine($"Not allowed. You have {word1.Length - i} tries left.\n");

                }


                else if (word1.Contains(guess) == true)
                {
                    Console.WriteLine("You guessed correctly !\n");
                    j += 1;
                }

                else
                {
                    i += 1;
                    Console.WriteLine($"You guessed wrongly ! You have {word1.Length - i} tries left\n");

                }

                /* If you guessed all the letters correctly this will print that you won */
                if (j == word1.Length)
                {
                    Console.Clear();
                    Console.WriteLine($"You won ! The guessing word was {word1}.\n");
                }
                /* If you tried too many times it will ends your program and you will lose.
                 * If you guessed all letters in a word correctly you win and the game is done. */

                if(i == word1.Length)
                {
                    Console.Clear();
                    Console.WriteLine($"You lost ! The guessing word was {word1}.\n");
                }

            } while (i != word1.Length & j != word1.Length);
        }
    }
}
