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

        public Puzzle()
        {
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
                {2, "bird" },
                {3, "beer" },
                {4, "swimming" },
                {5, "dictionary" },
                {6, "photosynthesis" },
                {7, "legume" },
                {8, "garden" },
                {9, "house" },
                {10, "shark" },
            };
    }
   
}
