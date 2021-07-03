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
        private readonly List<Puzzle> _puzzle = new List<Puzzle>();
        //create word
        public void AddWordToList(Puzzle puzzleWord)
        {
            _puzzle.Add(puzzleWord);
        }

        //read word

        public List<Puzzle> ReadWordFromList()
        {
            return _puzzle;
        }

    }
}
