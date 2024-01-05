using System;
using System.Collections.Generic;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        int value = 0;
        int current_index = -1;
        foreach (int element in myLList)
        {
            current_index++;
            if (current_index == n)
            {
                value = element;
                return value;
            }
        }
        return value;
    }
}