using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan
{
    public class DisneyWordGenerator : IWordGenerator
    {
        private string[] words = new string[10];

        public DisneyWordGenerator()
        {
            words[0] = "Ana";
            words[1] = "Aladin";
            words[2] = "Symba";
            words[3] = "Mickey";
            words[4] = "Miney";
            words[5] = "Goofy";
            words[6] = "Mulan";
            words[7] = "Sneezy";
            words[8] = "Grumpy";
            words[9] = "Donald";
        }

        public string GetWord()
        {
            Random r1 = new Random();
            int randomNum = r1.Next(0, 10);

            return words[randomNum];

        }//end getword


    }
}
