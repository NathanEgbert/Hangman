using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangManClass
{

    //testing git kraken
    public class Hangman
    {

        //declare vars
        private string[] words = new string[10];
        private List<char> wrongGuesses = new List<char>();
        private List<char> wordPlaceHolder = new List<char>();
        private int numberOfGuesses;
        private int correctGuesses;

        
        //constructor
        public Hangman()
        {
            numberOfGuesses = 0;
            correctGuesses = 0;

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
        public string getword()
        {
            Random r1 = new Random();
            int randomNum = r1.Next(0, 10);

            return words[randomNum];

        }//end getword


        //place holder word
        public void generatePlaceholderWord(string word1)
        {
           for(int i = 0; i < word1.Length; i++)
           {
               wordPlaceHolder.Add('*');
           }
        }//end generate place holder



        // checks the players guess
        public void checkGuess(char guess, string word)
        {
            
                for (int i = 0; i < word.Length;i++)
                {
                    if(word.ElementAt(i) == guess)
                    {
                        
                        wordPlaceHolder[i] = guess;
                        correctGuesses++;
                    
                    }
                }
  
                if(!(word.Contains(guess)))
                 {
                wrongGuesses.Add(guess);
                numberOfGuesses -= 1;
                 }

        }//end check guess

        public bool checkForWin(string word1)
        {
            if (correctGuesses == word1.Length)
            {
                return true;
            }
            else return false;
        }

        //prints guesses
        public void printGuesses()
        {
            Console.WriteLine("Incorrect guesses: "); 
            foreach(char element in wrongGuesses)
            {
                Console.Write(element);
            }
            Console.WriteLine("");
        }

        public void setNumOfGuesses(int wordLength)
        {
           if(wordLength > 10)
           {
               numberOfGuesses = 5;
           }

           if(wordLength > 5 && wordLength < 10)
           {
               numberOfGuesses = 4;
           }

           if(wordLength < 5)
           {
               numberOfGuesses = 3;
           }
        }

        //prints the placeholdder word
        public void printPlaceHolderWord(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {

                Console.Write(wordPlaceHolder[i]);

            }
            Console.WriteLine("");
        }//end print place holder word

        //getters
        public int getNumOfGuesses
        {
            get
            {
                return numberOfGuesses;
            }
        }//returns the number of guesses

        

    }//end hangman class

}
