using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessesPOCO
{
    public class Guesses
    {
        public char GuessedLetter { get; set; }

        public Guesses(char guessedLetter)
        {
            GuessedLetter = guessedLetter;
        }


        
    }

}
