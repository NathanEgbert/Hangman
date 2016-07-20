using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangManClass
{


    public class Hangman
    {

        //declare vars
        private string[] words = new string[10];
        private string wrongGuesses;
        private string wordPlaceHolder;
        private int numberOfGuesses;



        //constructor
        public Hangman()
        {
            wrongGuesses = "";
            numberOfGuesses = 0;


            words[0] = "python";
            words[1] = "java";
            words[2] = "mississippi";
            words[3] = "car";
            words[4] = "tacos";
            words[5] = "time";
            words[6] = "baseball";
            words[7] = "watch";
            words[8] = "agilethouht";
            words[9] = "deloitte";
        }//end constructor


        //gets the word to be played
        private string getword()
        {
            Random r1 = new Random();
            int randomNum = r1.Next(0, 10);

            return words[randomNum];

        }//end getword


        //place holder word
        private void generatePlaceholderWord(string word1)
        {
            
            
                wordPlaceHolder = new string('*', word1.Length);
            
        }//end generate place holder



        // checks the players guess
        private void checkGuess(char guess, string word)
        {

            var newstring = new StringBuilder(wordPlaceHolder);

            if (!(word.Contains(guess)))
            {
                wrongGuesses += guess;
                numberOfGuesses -= 1;
            }

            for (int i = 0; i < word.Length; i++)
            {
                if (word.ElementAt(i) == guess)
                {
                    newstring.Remove(i, 1);
                    newstring.Insert(i, guess);
                    wordPlaceHolder = newstring.ToString();
                }
            }

            

        }//end check guess

        private bool checkForWin()
        {


            return !wordPlaceHolder.Contains('*');


        }

        //prints guesses
        private void printGuesses()
        {
            Console.WriteLine("Incorrect guesses: ");
            if(wrongGuesses.Length==0)
            {
                Console.WriteLine("0");
            }
            for (var i = 0; i < wrongGuesses.Length;i++)
            {
                Console.Write(wrongGuesses.ElementAt(i));
            }
                Console.WriteLine("");
        }

        private void setNumOfGuesses(int wordLength)
        {
            if (wordLength > 10)
            {
                numberOfGuesses = 5;
            }

            if (wordLength >= 5 && wordLength < 10)
            {
                numberOfGuesses = 4;
            }

            if (wordLength < 5)
            {
                numberOfGuesses = 3;
            }
        }

        //prints the placeholdder word
        private void printPlaceHolderWord(string word)
        {
            Console.WriteLine();
            for (int i = 0; i < word.Length; i++)
            {

                Console.Write(wordPlaceHolder[i]);

            }
            Console.WriteLine("");
        }//end print place holder word

        //getters
        private int getNumOfGuesses
        {
            get
            {
                return numberOfGuesses;
            }
        }//returns the number of guesses


        public void Run()
        {
            char pGuess;
            string word;

            //getting a word
            word = getword();
            setNumOfGuesses(word.Length);

            //generate place holder word
            generatePlaceholderWord(word);

            Console.WriteLine("Play Game");

            Console.WriteLine();

            printPlaceHolderWord(word);

            Console.WriteLine();

            Console.WriteLine("You have: " + getNumOfGuesses + " guesses.");

            Console.WriteLine();

            do
            {


                Console.WriteLine("Enter a guess: ");


                pGuess = Console.ReadKey().KeyChar;


                checkGuess(pGuess, word);



                if (checkForWin() == true)
                {
                    Console.WriteLine();
                    Console.Write("The word was: ");

                    Console.WriteLine();

                    printPlaceHolderWord(word);

                    Console.WriteLine();

                    Console.WriteLine("You Win");

                    break;
                }
                printPlaceHolderWord(word);
                Console.WriteLine("");
                printGuesses();

                Console.WriteLine("");
                Console.WriteLine("You have: " + getNumOfGuesses + " guesses left.");
                Console.WriteLine("");

                if (getNumOfGuesses == 0)
                {
                    Console.WriteLine("You Lose!");
                }

            } while (getNumOfGuesses != 0);


        }




    }//end hangman class

}
