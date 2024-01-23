using System;

/// <summary>
/// represents a queue
/// </summary>
class Queue<T>
{
    public Node head;
    public Node tail;
    public int count;

    /// <summary> checks the type of queue </summary>
    public Type CheckType()
    {
        return typeof(T);
    }

    /// <summary> adds new node to Queue </summary>
    public void Enqueue(T value)
    {
        Node newNode = new Node();
        newNode.Value(value);

        if (count == 0)
        {
            this.head = newNode;
            this.count += 1;
        }
        else
        {
            newNode.next = this.head;
            this.head = newNode;
            this.count += 1;
        }
    }

    /// <summary> returns count in queue </summary>
    public int Count()
    {
        return this.count;
    }

    /// <summary>
    /// represents a node in the queue
    /// </summary>
    public class Node
    {
        public T value = default(T);
        public Node next = null;

        /// <summary> value constructor </summary>
        public void Value(T value)
        {
            this.value = value;
        }
    }
}