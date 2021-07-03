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
        bool stillAlive = true;
        public void Run()
        {
            AddWordToPuzzle();
            RunGame();
        }

        private void RunGame()
        {

            string c = GetPuzzle();
        }

        private string GetPuzzle()
        {
            
        }

        private void AddWordToPuzzle()
        {
            
        }

        
        
    }
}