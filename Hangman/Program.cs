using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            int chancesLeft = 6;
            int finishCount;
            string[] wordsList = { "capita", "object", "variable", "algorithm", "collections", "programming", "loops", "environment", "arrays", "debugging" };
            Random randomWordGen = new Random();
            int position = randomWordGen.Next(0, wordsList.Length);
            string selectedWord = wordsList[position];

            ArrayList wordsUsed = new ArrayList();

            Console.WriteLine("Welcome To Hangman!");
            Console.WriteLine("The Word is " + selectedWord.Length + " Characters Long!");

            char[] guess = new char[selectedWord.Length];
            for (int i = 0; i < selectedWord.Length; i++) {
                guess[i] = '*';
                Console.Write("*");
            }
            Console.WriteLine();
            
            while (true)
            {
                finishCount = 0;

                // check if the player has no more chances left
                if (chancesLeft == 0)
                {
                    Console.WriteLine("No More Chances Left! You Lose!");
                    Console.WriteLine("The Word was " + selectedWord);
                    break;
                }

                Console.Write("Please Enter Your Guess Character: ");
                var charProvided = Console.ReadLine();

                // check to make sure that the input is not empty
                if (charProvided == "")
                {
                    Console.WriteLine("No Guess Provided! Please Enter Your Guess Character: ");
                }
                // making sure no duplicate guesses
                else if (wordsUsed.Contains(char.Parse(charProvided))) {
                    Console.WriteLine("You Have Already Guessed This Character Before");
                }
                else
                {
                    char pGuess = char.Parse(charProvided);
                    char playerGuess = char.ToLower(pGuess);
                    wordsUsed.Add(playerGuess);

                    // decrease chances left by 1 if wrong guess
                    if (!selectedWord.Contains(playerGuess))
                    {
                        chancesLeft--;
                    }

                    // check to see if the word contains the guessed character
                    for (int j = 0; j < selectedWord.Length; j++)
                    {
                        if (playerGuess == selectedWord[j])
                        {
                            guess[j] = playerGuess;
                        }

                        // check to see if all of the blanks have been filled by letters
                        if (guess[j] == '*')
                        {
                            finishCount++;
                        }
                    }
                    Console.WriteLine(guess);

                    // word completed
                    if (finishCount == 0)
                    {
                        Console.WriteLine("Well Done! You Win");
                        break;
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
