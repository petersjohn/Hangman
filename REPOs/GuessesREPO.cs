using GuessesPOCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace REPOs
{
    public class GuessesREPO
    {
        //create
        private readonly List<Guesses> _guesses = new List<Guesses>();

        //read
        public List<Guesses> ReadListOfGuesses()
        {
            return _guesses;
        }




        //Update
        public void AddLetterToList(Guesses guessLetter)
        {
            _guesses.Add(guessLetter);
        }
        //show new list of guessed letters

        //update stillAlive
        public bool UpdateStillAlive(int numOfWrongGuesses)
        {
            if (numOfWrongGuesses == 7)
            {
                return false;
            }
            else
                return true;
        }


    }
}
