using System;
using System.Collections.Generic;

namespace Week10Exercise5
{
    internal class Program
    {
        public static string startingText = "This is the TEXT. Text, text, text – THIS TEXT! Is this the text?";
        static void Main(string[] args)
        {
            string lowStartText = startingText.ToLower();
            string[] seperators = { " ", ".", "–", "!", "?", "," };
            string[] seperated = lowStartText.Split(seperators, StringSplitOptions.RemoveEmptyEntries);

            IDictionary<String, int> words = new Dictionary<String, int>();
            foreach (string word in seperated)
            {
                if (words.ContainsKey(word))
                {
                    words[word]++;
                }
                else
                {
                    words.Add(word, 1);
                }
            }
            foreach (var word in words)
            {
                Console.WriteLine("{0} occured {1} times.", word.Key, word.Value);
            }

        }
    }
}