using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task3
{
    class WordCounter
    {
        public static Dictionary<string, int> CountWords(string input)
        {
            if (!string.IsNullOrEmpty(input))
            {
                var words = Regex.Split(input, @"\W+");
                var dictionary =
                    new Dictionary<string, int>(StringComparer.InvariantCultureIgnoreCase);

                foreach (var word in words)
                {
                    if (dictionary.ContainsKey(word))
                    {
                        dictionary[word]++;
                    }
                    else
                    {
                        dictionary.Add(word, 1);
                    }
                }
                return dictionary;
            }
            else
            {
                throw new Exception("Input string is null!");
            }
        }
    }
}
