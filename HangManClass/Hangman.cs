using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan
{


    public class Hangman
    {
        
       IWordGenerator wordGenerator;

        //declare vars
        
        private string wrongGuesses;
        private StringBuilder wordPlaceHolder = new StringBuilder();
        private int numberOfGuesses;



        //constructor
        public Hangman(WordType generatorType)
        {
            switch (generatorType)
            {
                case WordType.Disney:
                    wordGenerator = new DisneyWordGenerator();
                    break;

                default:
                    wordGenerator = new HardCodedWordGenerator();
                    break;

            }//end switch

            wrongGuesses = "";
            numberOfGuesses = 0;
 
        }//end constructor


        //gets the word to be played
        


        //place holder word
        private void generatePlaceholderWord(string word1)
        {

             wordPlaceHolder = new StringBuilder(new String('*', word1.Length));
                
            
        }//end generate place holder



        // checks the players guess
        private void checkGuess(char guess, string word)
        {

            

            if (!(word.Contains(guess)))
            {
                wrongGuesses += guess;
                numberOfGuesses -= 1;
            }//end if

            for (int i = 0; i < word.Length; i++)
            {
                if (word.ElementAt(i) == guess)
                {
                    
                    wordPlaceHolder.Remove(i, 1);
                    wordPlaceHolder.Insert(i, guess);
                    
                }//end if
            }//end for

            

        }//end check guess

        private bool checkForWin()
        {


            return !wordPlaceHolder.ToString().Contains('*');


        }//end check for win

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
        }//end print guesses

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
        }//end set number of guesses

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

        


        public void Run()
        {
            
            char pGuess;
            string word;

            //getting a word
            word = wordGenerator.GetWord();

            
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


        }//end run

        //getters
        private int getNumOfGuesses
        {
            get
            {
                return numberOfGuesses;
            }
        }//returns the number of guesses




    }//end hangman class

}
