using System;

namespace Text
{
    /// <summary>
    /// String opertations
    /// </summary>
    public class Str
    {
        /// <summary> How Many Words in string </summary>
        public static int CamelCase(string s)
        {
            int count = 0;
            if (s.Length == 0)
            {
                return count;
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsUpper(s[i]))
                {
                    count++;
                }
            }
            return count + 1;
        }
    }
}
