using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessesPOCO
{
    public class Puzzle
    {

        
        public string Puzzleword
        {
          
            get { 
                string puzzleWord = getWordFromDictionary();
                return puzzleWord;
            }
            set { }
            
        }
            
             

        public Puzzle(string puzzleWord)
        {
            Puzzleword = puzzleWord;

        }
        public string getWordFromDictionary()
        {
            Random wordNum = new Random();
            int numOfWord = wordNum.Next(1, 11);
            string retrievedWord = ListOfWords[numOfWord];
            return retrievedWord;
        }

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
    }
   
}
