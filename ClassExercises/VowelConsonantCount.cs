using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassExercises
{
    public class VowelConsonantCount
    {
        private string sentence;
        public VowelConsonantCount(string sentence)
        {

            this.sentence = sentence;

        }
        private void IgnoreCaseAndSymbols()
        {
            sentence=sentence.ToLower().Trim();
            sentence = Regex.Replace(sentence, "[^a-zA-Z0-9]", "", RegexOptions.Compiled);
            
        }
        private double Percentage(double numberOfOccurance)
        {
            return (numberOfOccurance / sentence.Length) * 100;
        }
        public void GetVowelConsonantDetails()
        {
            Dictionary<char,int> wordCount = new Dictionary<char,int>();
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            int vowelCount = 0;
            int consonantCount = 0;
            IgnoreCaseAndSymbols();
            foreach (char c in sentence)
            {
                if (vowels.Contains(c))
                {
                    vowelCount++;
                }
                else
                {
                    consonantCount++;
                }

                if (wordCount.ContainsKey(c))
                {
                    wordCount[c]++;
                }
                else
                {
                    wordCount.Add(c, 1);
                    
                }
            }
            PrintDetailToScreen(vowelCount, consonantCount,vowels, wordCount);
        }

        private void PrintDetailToScreen(int vowelCount, int consonantCount, char[] vowels, Dictionary<char, int> wordCount)
        {
            //List<char> sortedwords= new List<char> { wordCount.Keys.ToList().Sort()};
            Console.WriteLine("Details of your sentence is as follows");
            Console.WriteLine("Total word count is: " + sentence.Length);
            Console.WriteLine();
            Console.WriteLine("Vowels count is: "+  vowelCount);
            Console.WriteLine("Consonant count is: " + consonantCount);
            Console.WriteLine();
            Console.WriteLine("Each alphabet appearance count is:");
            foreach (char c in wordCount.Keys)
            {
                Console.WriteLine($"{c}: {wordCount[c]}({Percentage(wordCount[c]):F2}%)");
            }
           // Console.WriteLine(wordCount.OrderBy)
        }
    }
}
