using System;

public class Node
{
    public int Data;
    public Node Next;

    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}

public class LinkedList
{
    public Node Head;

    public void Insert(int data)
    {
        Node newNode = new Node(data);
        if (Head == null)
            Head = newNode;
        else
        {
            Node temp = Head;
            while (temp.Next != null)
                temp = temp.Next;
            temp.Next = newNode;
        }
    }

    public void Traverse()
    {
        Node temp = Head;
        Console.WriteLine("Linked List elements:");
        while (temp != null)
        {
            Console.Write(temp.Data + " -> ");
            temp = temp.Next;
        }
        Console.WriteLine("null");
    }
}

public class SinglyLinkedList
{
    public static void Main(string[] args)
    {
        LinkedList list = new LinkedList();
        Console.Write("Enter the number of elements: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter element {i + 1}: ");
            int data = int.Parse(Console.ReadLine());
            list.Insert(data);
        }

        list.Traverse();
    }   
}
