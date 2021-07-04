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

        public Guesses GetGuessByChar(char guessChar)
        {
            foreach (var guess in _guesses)
            {
                if (guess.GuessedLetter == guessChar)
                    return guess;
            }
            return null;
        }
       
        //Update
        public void AddLetterToList(Guesses guessLetter)
        {
           
            _guesses.Add(guessLetter);
            
            
        }
        

        //update stillAlive
        public bool UpdateStillAlive(int numOfWrongGuesses)
        {   
            if (numOfWrongGuesses == 6)
            {
                return false;
            }
            else
                return true;
        }


    }
}
