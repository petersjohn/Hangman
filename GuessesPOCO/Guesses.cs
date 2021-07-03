using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessesPOCO
{
    public class Guesses
    {
        public char GussedLetter { get; set; }

        public Guesses(char guessedLetter)
        {
            GussedLetter = guessedLetter;
        }


        
    }

}
