using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HangMan
{
    class HangManConsole
    {

        public static void Main(string[] args)
        {
            
           
            Hangman g1 = new Hangman(WordType.HardCoded);

            g1.Run();

            

        }
    }
}
