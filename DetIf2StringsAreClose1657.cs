using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode75
{
    class DetIf2StringsAreClose1657
    {

        public static bool CloseStringsBetterSolution(string word1, string word2)
        {
            if (word1.Length != word2.Length)
                return false;
            if (word1 == word2)
                return true;

            var letters1 = new int[26];
            var letters2 = new int[26];

            for (int i = 0; i < word1.Length; i++)
            {
                letters1[word1[i] - 'a']++;
                letters2[word2[i] - 'a']++;
            }

            if (!letters1.SequenceEqual(letters2))
            {
                for (int i = 0; i < 26; i++)
                {
                    if (letters1[i] != letters2[i] && (letters1[i] == 0 || letters2[i] == 0))
                    {
                        return false;
                    }
                }

                Array.Sort(letters1);
                Array.Sort(letters2);
                return letters1.SequenceEqual(letters2);
            }

            return true;
        }
        public static bool CloseStrings(string word1, string word2)
        {
            if (word1.Length != word2.Length)
                return false;

            var dictionary1 = new SortedDictionary<char, int>();
            var dictionary2 = new SortedDictionary<char, int>();

            foreach (char letter in word1)
            {
                AddOrUpdateCharCount(dictionary1, letter);
            }
            foreach (char letter in word2)
            {
                AddOrUpdateCharCount(dictionary2, letter);
            }

            foreach (var pair in dictionary1)
            {
                Console.WriteLine("Char: " + pair.Key + ", count: " + pair.Value);
            }

            Console.WriteLine();

            foreach (var pair in dictionary2)
            {
                Console.WriteLine("Char: " + pair.Key + ", count: " + pair.Value);
            }

            SortDictionaryByValue(dictionary1);
            SortDictionaryByValue(dictionary2);

            Console.WriteLine();

            foreach (var pair in dictionary1)
            {
                Console.WriteLine("Char: " + pair.Key + ", count: " + pair.Value);
            }

            Console.WriteLine();

            foreach (var pair in dictionary2)
            {
                Console.WriteLine("Char: " + pair.Key + ", count: " + pair.Value);
            }
            return AreDictionariesEqual(dictionary1, dictionary2);
        }


        private static bool AreDictionariesEqual(SortedDictionary<char, int> dict1, SortedDictionary<char, int> dict2)
        {
            // Check if the counts are the same
            if (dict1.Count != dict2.Count)
            {
                return false;
            }

            // Compare each key-value pair
            foreach (var pair in dict1)
            {
                if (!dict2.TryGetValue(pair.Key, out int value) || value != pair.Value)
                {
                    return false;
                }
            }

            return true;
        }

        private static void SortDictionaryByValue(SortedDictionary<char, int> d)
        {
            var list1 = new List<int>(d.Values);
            list1.Sort();

            int index = 0;
            foreach (var key in d.Keys.ToList())
            {
                d[key] = list1[index];
                index++;
            }
        }


        private static void AddOrUpdateCharCount(SortedDictionary<char, int> dict, char c)
        {
            if (dict.TryGetValue(c, out int count))
            {
                dict[c] = count + 1;
            }
            else
            {
                dict[c] = 1;
            }
        }
    }


}
