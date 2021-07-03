using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessesPOCO
{
    public class Puzzle
    {
        public string Puzzleword { get; set; }

        public Puzzle(string puzzleWord)
        {
            Puzzleword = puzzleWord;

        }
    }
}
