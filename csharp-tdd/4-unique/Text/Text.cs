using System;
using System.Collections.Generic;

namespace Text
{
    /// <summary>
    /// Operations for strings
    /// </summary>
    public class Str
    {
        /// <summary> returns the index of the first non-repeating character of a string </summary>
        public static int UniqueChar(string s)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            foreach (char c in s)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                }
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (charCount[s[i]] == 1)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
