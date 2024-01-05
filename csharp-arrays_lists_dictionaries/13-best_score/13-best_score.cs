using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        string high_score = "";
        int currentscore = 0;
        foreach (KeyValuePair<string, int> kvp in myList)
        {
            if (kvp.Value > currentscore)
            {
                currentscore = kvp.Value;
                high_score = kvp.Key;
            }
        }
        return high_score;
    }
}