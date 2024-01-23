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
            Node currentN = this.head;
            while (currentN != null)
            {
                if (currentN.next == null)
                {
                    currentN.next = newNode;
                    break;
                }
                currentN = currentN.next;
            }
            this.count += 1;
        }
        Node current = this.head;
        while (current != null)
        {
            if (current.next == null)
            {
                this.tail = current;
                break;
            }
            current = current.next;
        }
    }

    /// <summary> for dequeuing </summary>
    public T Dequeue()
    {
        if (this.count < 1)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        T value = this.head.value;
        Node next = this.head.next;
        this.head = next;
        this.count -= 1;
        return value;
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