//using System;
////using System.ComponentModel;
//namespace LinkedList;

//class Node
//{
//    public int data;
//    public Node next;

//    public Node(int data)
//    {
//        this.data = data;
//        this.next = null;
//    }
//}

//public class LinkedList
//{
//    private Node head;

//    public LinkedList()
//    {
//        head = null;
//    }

//    public void Append(int data)
//    {
//        Node newnode = new Node(data);
//        if (head == null)
//        {
//            head = newnode;
//            return;
//        }

//        Node temp = head;
//        while (temp.next != null)
//        {
//            temp = temp.next;
//        }
//        temp.next = newnode;
//    }

//    public void Prepend(int data)
//    {
//        Node newnode = new Node(data);
//        if (head == null)
//        {
//            head = newnode;
//            return;
//        }

//        Node temp = head;
//        head = newnode;
//        newnode.next = temp;
//    }

//    public void Delete(int data)
//    {

//        if (head == null)
//        {
//            return;
//        }
//        if (head.data == data)
//        {
//            head = head.next;
//            return;
//        }
//        Node current = head;
//        while (current.next != null)
//        {
//            if (current.next.data == data)
//            {
//                current.next = current.next.next;
//                return;
//            }
//            current = current.next;
//        }
//    }
//    public void PrintList()
//    {
//        Node temp = head;
//        while (temp != null)
//        {
//            Console.Write(temp.data + " -> ");
//            temp = temp.next;
//        }
//        Console.WriteLine("null");
//        //Console.WriteLine(temp);
//        // Console.WriteLine(temp.next) gives null reference error
//    }
//}
//public class Program
//{
//    static void Main(string[] args)
//    {
//        LinkedList list = new LinkedList();
//        list.Append(10);
//        list.Append(20);
//        list.Append(30);
//        list.Prepend(5);
//        list.PrintList();
//        list.Delete(20);
//        list.PrintList();
//        Console.ReadKey();
//    }
//}
