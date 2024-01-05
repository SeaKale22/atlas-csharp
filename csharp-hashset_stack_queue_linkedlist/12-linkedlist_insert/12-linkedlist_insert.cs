using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> current_node = myLList.First;
        LinkedListNode<int> new_node;
        while (current_node != null)
        {
            if (current_node.Value < n && current_node.Next == null)
            {
                new_node = myLList.AddAfter(current_node, n);
                return new_node;
            }
            else if (current_node.Value < n && current_node.Next.Value > n)
            {
                new_node = myLList.AddAfter(current_node, n);
                return new_node;
            }
            current_node = current_node.Next;
        }
        new_node = myLList.AddFirst(n);
        return new_node;

    }
}