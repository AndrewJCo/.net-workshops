using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace NumberWorder
{
    public class NumberWordProcessor
    {
        public Dictionary<char, string> NumberLookup = new Dictionary<char, string> {
            {'0', "ZERO"},
            {'1', "ONE"},
            {'2', "TWO"},
            {'3', "THREE"},
            {'4', "FOUR"},
            {'5', "FIVE"},
            {'6', "SIX"},
            {'7', "SEVEN"},
            {'8', "EIGHT"},
            {'9', "NINE"}
        };

        /// <summary>
        /// Converts each numeric character into it's word equivalent
        /// </summary>
        /// <param name="numbers">A single numeric parameter.</param>
        /// <returns>1234 returns ONETWOTHREEFOUR</returns>
        public string ConvertNumbersToWords(string numbers)
        {
            if (string.IsNullOrEmpty(numbers)) throw new ArgumentNullException(numbers);
            if (!Regex.IsMatch(numbers, @"^[0-9]+$")) throw new ArgumentException("Must be only numeric e.g. 1234", numbers);

            var words = new StringBuilder();

            foreach (var c in numbers.ToCharArray())
            {
                words.Append(NumberLookup[c]);
            }

            return words.ToString();
        }
    }
}