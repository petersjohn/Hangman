using REPOs;
using GuessesPOCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramUI
{

    public class UI
    {
        GuessesREPO guessesRepo = new GuessesREPO();

        PuzzleREPO puzzleRepo = new PuzzleREPO();

        public readonly List<Guesses> _guessesList = new List<Guesses>();
        
        public int incorrectGuessCnt;
        
        public string returnStr;
        
        bool stillAlive = true;


        public void SetupAndStart()
        {
            string puzzle = CreatePuzzle();
            InitGame(puzzle);
            Run(puzzle);
        }

        public void Run(string puzzle)
        {
            while (stillAlive == true)
            {
                GameConsole(puzzle);
            }

        }



        private void GameConsole(string puzzle)
        {
            string currentPuzzle = puzzle;

            char guess = EnterLetter();

            if (GetGuessByLetter(guess) != null)
            {
                Console.WriteLine("You've already guessed that, try again. Press any key to continue.");
                Console.ReadKey();
                GameConsole(currentPuzzle);
            }
            else
            {
                Guesses guesses = new Guesses(guess);
                AddLetterToGuesses(guesses);
                if (!ValidateGuess(guess, currentPuzzle))
                {

                    incorrectGuessCnt = incorrectGuessCnt + 1;
                    if (!guessesRepo.UpdateStillAlive(incorrectGuessCnt))
                    {
                        Console.WriteLine("Ha Ha you lose! Press any key to go home and cry.");
                        Console.ReadKey();
                         stillAlive = false;
                    }
                    else
                    {
                        Console.WriteLine("LOL, nope. Press any key to continue");
                        Console.ReadLine();
                    };
                    

                }
                else
                {
                    StringBuilder sb = new StringBuilder(returnStr);
                    for (int idx = 0; idx < currentPuzzle.Length; idx++)
                    {
                        if (currentPuzzle[idx].Equals(guess))
                        {
                            sb[idx] = guess;
                            returnStr = sb.ToString();
                        }

                    }
                    if (CheckForWin(currentPuzzle, returnStr))
                    {
                        Console.WriteLine("You did it!! Press any key to exit.");
                        Console.ReadKey();
                        stillAlive = false;
                    }
                    else 
                    {
                        Console.WriteLine("Got one! Press any key to continue.");
                        Console.ReadLine();
                    }
                    
                    

                    

                }

            }

        }

       
        public bool ValidateGuess(char letter, string puzzle)
        {
            foreach (char c in puzzle)
            {
                if (c == letter)
                {
                    return true;
                }
            }
            return false;
        }

        public Guesses GetGuessByLetter(char letter)
        {

            Guesses guess = guessesRepo.GetGuessByChar(letter);
            if (guess != null)
            {
                return guess;
            }
            else
            {
                return null;
            }


        }

        public string BuildGuessString()
        {
            List<Guesses> guess = guessesRepo.ReadListOfGuesses();
            string guessString = " ";
            if(guess.Count > 0)
            {
                foreach (var item in guess)
                {
                    guessString = (guessString + item.GuessedLetter + " ");
                }
            }
            return guessString;
            



        }

        private void AddLetterToGuesses(Guesses guesses)
        {
            guessesRepo.AddLetterToList(guesses);
        }

        private string CreatePuzzle()
        {
            return puzzleRepo.ReadWord();
        }
        private void InitGame(string puzzle)
        {
            incorrectGuessCnt = 0;


            for (int idx = 0; idx < puzzle.Length; idx++)

            {
                returnStr += "*";
            }
            Console.WriteLine($"Welcome to Console Hangman!\n" +
                $"Press Any Key to Continue");
            Console.ReadKey();
           

         }

        public bool CheckForWin(string puzzle, string returnString)
        {
            if (puzzle == returnString)
            {
                return true;
            }
            return false;
                
        }
        public char EnterLetter()
        {
            int guessesLeft = 6 - incorrectGuessCnt;
            string guessesLeftStr = guessesLeft.ToString();
            string guessString = BuildGuessString();
            Console.Clear();
            Console.WriteLine($"Puzzle:   {returnStr}\n" +
                $"Guesses:   {guessString}\n" +
                $"Strikes Left:    {guessesLeft}\n" +
                $"Please Enter A Letter: ");
            //Console.WriteLine("Please Enter A Letter: ");
            char userInput = Char.Parse(Console.ReadLine());

            return userInput;
        }
    }
}

