//using System;

//class Node
//{
//    public int Data;
//    public Node Next;

//    public Node(int data)
//    {
//        Data = data;
//        Next = null;
//    }
//}

//class LinkedList
//{
//    private Node head;

//    public LinkedList()
//    {
//        head = null;
//    }

//    // Add a node at the end
//    public void Append(int data)
//    {
//        Node newNode = new Node(data);
//        if (head == null)
//        {
//            head = newNode;
//            return;
//        }

//        Node temp = head;
//        while (temp.Next != null)
//        {
//            temp = temp.Next;
//        }
//        temp.Next = newNode;
//    }

//    // Insert at the beginning
//    public void Prepend(int data)
//    {
//        Node newNode = new Node(data);
//        newNode.Next = head;
//        head = newNode;
//    }

//    // Delete a node by value
//    public void Delete(int data)
//    {
//        if (head == null) return;

//        if (head.Data == data)
//        {
//            head = head.Next;
//            return;
//        }

//        Node current = head;
//        while (current.Next != null)
//        {
//            if (current.Next.Data == data)
//            {
//                current.Next = current.Next.Next;
//                return;
//            }
//            current = current.Next;
//        }
//    }

//    // Display the linked list
//    public void PrintList()
//    {
//        Node temp = head;
//        while (temp != null)
//        {
//            Console.Write(temp.Data + " -> ");
//            temp = temp.Next;
//        }
//        Console.WriteLine("null");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        LinkedList list = new LinkedList();
//        list.Append(10);
//        list.Append(20);
//        list.Append(30);
//        list.Prepend(5);

//        Console.WriteLine("Linked List:");
//        list.PrintList(); // Output: 5 -> 10 -> 20 -> 30 -> null

//        Console.WriteLine("After Deleting 20:");
//        list.Delete(20);
//        list.PrintList(); // Output: 5 -> 10 -> 30 -> null
//        Console.ReadKey();
//    }
//}

