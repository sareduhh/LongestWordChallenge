using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace LongestWordChallenge
{
    class Program
    {
        static void Main(string[] args)
        {

            string sentence = "I have to use the bathroom";
            int sentLength = sentence.Length;
            string[] sent = sentence.Split(' ');

            string longWord = "";

            foreach(string word in sent)
            {
                //For each word in the array we need to count the characters (chars) in each word and determine which has the most chars
                int wordLength = word.Length;
                int longestWordLength = longWord.Length;

                if(wordLength > longestWordLength)
                {
                    longestWordLength = wordLength;
                    longWord = word;
                }
            }
            Console.WriteLine(longWord);
        }
    }
}
