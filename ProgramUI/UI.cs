using REPOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramUI
{

    public class UI
    {

        public void Run()
        {
            
            GuessesREPO guessesRepo = new GuessesREPO();
            bool stillAlive = true;
            int numOfWrongGuesses = 0;
            char userInput;
          

            Console.WriteLine("What letter is your guess?");
            userInput = char.Parse(Console.ReadLine());

            
            foreach(char c in GuessesREPO.puzzleWord)
            {
                if (stillAlive)
                {
                    if ()
                    if (userInput == c)
                    {
                        Console.WriteLine("Correct!");

                    }
                    else
                    {
                        Console.WriteLine("That is not correct.");
                        numOfWrongGuesses += 1;
                        stillAlive = GuessesREPO.UpdateStillAlive(numOfWrongGuesses);
                    }
                         
                }
            }

            

            





            Console.ReadKey();
        }

    }
}