using System;
using System.Linq;

namespace Text
{
    /// <summary>
    /// operations for strings
    /// </summary>
    public class Str
    {
        /// <summary> determins if string is a palindrome </summary>
        public static bool IsPalindrome(string s)
        {
            string convertedString = new string(s.ToLower().ToCharArray().Where(c => Char.IsLetterOrDigit(c)).ToArray());
            string reversedString = new string(convertedString.Reverse().ToArray());
            return convertedString == reversedString;
        }
    }
}
