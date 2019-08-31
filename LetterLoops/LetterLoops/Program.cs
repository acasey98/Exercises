using System;
using System.Collections.Generic;

namespace LetterLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            var letters = Console.ReadLine();
            var printOut = "";
            foreach (char letter in letters)
            {
                var charIndex = letters.IndexOf(letter) + 1;
                for (var i = charIndex; i > 0; i--)
                {
                    char currLetter;
                    if (i == charIndex)
                    {
                        currLetter = char.ToUpper(letter);
                    }
                    else
                    {
                        currLetter = letter;
                    }
                    printOut += currLetter;
                }
                if (charIndex < letters.Length)
                {
                    printOut += "-";
                }
            }
            Console.WriteLine(printOut);
        }
    }
}
