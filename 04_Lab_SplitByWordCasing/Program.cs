using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Lab_SplitByWordCasing
{
    class Program
    {
        static void Main(string[] args)
        {
            var separators = new char[]
            {
                ',', ';', ':', '.', '!', '(', ')', '"', '\'', '/', '\\', '[', ']', ' '
            };
            var words = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);
            var lowerCaseList = new List<string>();
            var upperCaseList = new List<string>();
            var mixedCaseList = new List<string>();

            foreach (var w in words)
            {
                var type = GetWordType(w);
                if (type == WordType.Uppercase)
                {
                    upperCaseList.Add(w);
                } else if (type == WordType.Lowercase)
                {
                    lowerCaseList.Add(w);
                }
                else
                {
                    mixedCaseList.Add(w);
                }
            }
            Console.WriteLine("Lower-case: {0}", String.Join(", ", lowerCaseList));
            Console.WriteLine("Mixed-case: {0}", String.Join(", ", mixedCaseList));
            Console.WriteLine("Upper-case: {0}", String.Join(", ", upperCaseList));
        }

        enum WordType
        {
            Uppercase,
            Lowercase,
            MixedCase
        };

         static WordType GetWordType(string word)
         {
             var lowerLetters = 0;
             var upperLetters = 0;
             foreach (var l in word)
             {
                 if (char.IsUpper(l))
                 {
                     upperLetters++;
                 }
                 else if (char.IsLower(l))
                 {
                     lowerLetters++;
                 }
             }
             if (upperLetters == word.Length)
                 {
                     return WordType.Uppercase;
                 }
                 if (lowerLetters == word.Length)
                 {
                     return WordType.Lowercase;
                     
                 }
            return WordType.MixedCase;
             }
         }
    }
