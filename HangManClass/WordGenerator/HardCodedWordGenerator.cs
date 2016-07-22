using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan
{
    public class HardCodedWordGenerator : IWordGenerator
    {
        private string[] words = new string[10];

        public HardCodedWordGenerator()
        {
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
        }

        public string GetWord()
        {
            Random r1 = new Random();
            int randomNum = r1.Next(0, 10);

            return words[randomNum];

        }//end getword


    }
}
