using GuessesPOCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPOs
{
    public class PuzzleREPO
    {
        public Puzzle puzzleWord = new Puzzle();
        
        public string ReadWord()
        {
            string w = (string)puzzleWord.Puzzleword;
            return w;
        }



    }
}
