using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ListNode
{
    public int data;
    public ListNode next;

    public ListNode(int value)
    {
        data = value;
        next = null;
    }
}

public class CircularLinkedList
{
    private ListNode last;

    public CircularLinkedList()
    {
        last = null;
    }

    public void Insert(int value)
    {
        ListNode newNode = new ListNode(value);

        if (last == null)
        {
            newNode.next = newNode;
            last = newNode;
        }
        else
        {
            newNode.next = last.next;
            last.next = newNode;
            last = newNode;
        }
    }

    public void Display()
    {
        if (last == null)
        {
            Console.WriteLine("List is empty.");
            return;
        }

        ListNode temp = last.next;
        do
        {
            Console.Write(temp.data + " -> ");
            temp = temp.next;
        } while (temp != last.next);
    }

    public static void Main(String[] args)
    {
        CircularLinkedList cal = new CircularLinkedList();

        Console.Write("Enter number of elements: ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter value: ");
            int val = Convert.ToInt32(Console.ReadLine());
            cal.Insert(val);
        }

        Console.WriteLine("\nCircular Linked List:");
        cal.Display();
    }
}
