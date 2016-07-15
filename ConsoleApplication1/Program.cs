using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HangManClass;

namespace ConsoleApplication1
{
    class HangManConsole
         
    {

        static char pGuess;
        static string word;
        static Hangman g1 = new Hangman();

        public static void Main(string[] args)
        {
            //getting a word
            word = g1.getword();
            g1.setNumOfGuesses(word.Length);

            //generate place holder word
            g1.generatePlaceholderWord(word);

            Console.WriteLine("Play Game");
             
            Console.WriteLine("");

            printPlaceHolderWord();

            Console.WriteLine("");

            Console.WriteLine("You have: " + g1.getNumOfGuesses + " guesses.");

            Console.WriteLine("");

            do
            {


                Console.WriteLine("Enter a guess: ");
                pGuess = Convert.ToChar(Console.ReadLine());

                g1.checkGuess(pGuess, word);
                g1.checkForWin(word);
                if(g1.checkForWin(word) == true)
                {
                   Console.Write("The word was: ");
                   printPlaceHolderWord();
                    Console.WriteLine("");
                    Console.WriteLine("You Win");
                    break;
                }
                printPlaceHolderWord();

                g1.printGuesses();

                
                Console.WriteLine("You have: " + g1.getNumOfGuesses + " guesses left.");


            } while (g1.getNumOfGuesses != 0);

            
        }

        //prints the place holder word
        public static void printPlaceHolderWord()
        {
            for (int i = 0; i < word.Length; i++ )
            {

                Console.Write(g1.wordPlaceHolder[i]);

            }
            Console.WriteLine("");
        }//end print place holder word
    }
}
