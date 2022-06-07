using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class WordCounter
    {
        public int Count(string text)
        {
            int counter = 0;
            bool passed = false;
            for (int i = 1; i < text.Length; i++)
            {
                if (char.IsWhiteSpace(text[i-1])==true || char.IsDigit(text[i-1])==true|| char.IsPunctuation(text[i-1])==true || char.IsSymbol(text[i-1])==true)
                {
                    if (char.IsLetter(text[i])==true )
                    {
                        counter++;
                        passed = true;
                    
                    }
                }
            }
            if (text.Length > 2 && passed)
            {
                counter++;
            }

            return counter;
        }
    }
}
