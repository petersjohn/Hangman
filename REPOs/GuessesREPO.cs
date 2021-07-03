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
        public Dictionary<int, string> ListOfWords = new Dictionary<int, string>
            {
                {1, "watermelon" },
                {2, "Bird" },
                {3, "Beer" },
                {4, "Swimming" },
                {5, "Dictionary" },
                {6, "Photosynthesis" },
                {7, "Legume" },
                {8, "Garden" },
                {9, "House" },
                {10, "Shark" },
            };

        

        //CRUD
        private readonly List<Guesses> _incorrectGuessList = new List<Guesses>();
    //Create 
            //Generate Random Number
        int RNG()
        {
            Random wordNum = new Random();

            int numOfWord = wordNum.Next(1, 11);
            return numOfWord;
        }

         //add guess to list of guesses
        public void AddLetterToList(Guesses guessLetter)
        {
            _incorrectGuessList.Add(guessLetter);
        }

        //Read

        

        public bool CharCheck(char input, char letterInPuzzleSeq)
        {
            if (input == letterInPuzzleSeq)
            {
                return true;
            }
            else
                return false;

        } 
        

        //Method to pull word from Dictionary
        
        public string Puzzle()
        {
            string puzzleWord;
            {
                int path = RNG();

                puzzleWord = ListOfWords[path];
                return puzzleWord;

            }
        }

        //read current list to avoid duplicates
        public List<Guesses> GetAllIncorrectGuesses()
        {
            return _incorrectGuessList;
        }




    //Update


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
