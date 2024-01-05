using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        LinkedListNode<int> current_node = myLList.First;
        for (int i = 0; i <= index; i++)
        {
            if (current_node == null)
            {
                return;
            }
            if (i == index)
            {
                myLList.Remove(current_node);
            }
            current_node = current_node.Next;
        }
    }
}