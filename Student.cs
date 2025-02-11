//using System;
//using System.Data;
////namespace LinkedList;
//// class node that represents a single node
//public class Node
//{
//    public int rollNumber;
//    public string name;
//    public int age;
//    public int grade;
//    public Node next;

//    public Node(int rollNumber, string name, int age, int grade)
//    {
//        this.rollNumber = rollNumber;
//        this.name = name;
//        this.age = age;
//        this.grade = grade;
//        this.next = null;
//    }
//}
//// linkelist class that is used to perform and manage nodes
//public class LinkedList
//{
//    private Node head;

//    public LinkedList()
//    {
//        head = null;
//    }
//    //Mtrhod to add element in the last
//    public void Append(int rollNumber, string name, int age, int grade)
//    {
//        Node newNode = new Node(rollNumber, name, age, grade);
//        if (head == null)
//        {
//            head = newNode;
//            return;
//        }
//        Node temp = head;
//        while (temp.next != null)
//        {
//            temp = temp.next;
//        }
//        temp.next = newNode;
//    }
//    //Method to add element in the first
//    public void Prepend(int rollNumber, string name, int age, int grade)
//    {
//        Node newNode = new Node(rollNumber, name, age, grade);
//        if (head == null)
//        {
//            head = newNode;
//            return;
//        }
//        newNode.next = head;
//        head = newNode;

//    }
//    //Method to insert a node at a given index
//    public void InsertAtIndex(int rollNumber, string name, int age, int grade, int index)
//    {
//        Node newNode = new Node(rollNumber, name, age, grade);
//        if (head == null)
//        {
//            head = newNode;
//            return;
//        }
//        if (index == 1)
//        {
//            Prepend(rollNumber, name, age, grade);
//            return;
//        }
//        int count = 1;
//        Node current = head;
//        while (count != index - 1)
//        {
//            current = current.next;
//            count++;
//        }
//        Node node = current.next;
//        current.next = newNode;
//        newNode.next = node;
//    }
//    //Method to display the nodes
//    public void Display()
//    {
//        if (head == null)
//        {
//            return;
//        }
//        Node temp = head;
//        while (temp != null)
//        {
//            Console.WriteLine("Roll NUmber: " + temp.rollNumber + " ,Name: " + temp.name + " ,Age: " + temp.age + " ,Grade: " + temp.grade);
//            //Console.WriteLine();
//            //Console.WriteLine();
//            //Console.WriteLine();
//            temp = temp.next;
//        }
//    }
//    //Method to delete Based on the roll number
//    public void DeleteRoll(int rollNumber)
//    {
//        if (head == null)
//        {
//            return;
//        }
//        if (head.rollNumber == rollNumber)
//        {
//            head = head.next;
//            return;
//        }
//        Node temp = head;
//        while (temp != null)
//        {
//            if (temp.next.rollNumber == rollNumber)
//            {
//                temp.next = temp.next.next;
//                return;

//            }
//            temp = temp.next;
//        }
//    }
//    //Display student details based on the roll number
//    public void DisplayRoll(int rollNumber)
//    {
//        if (head == null)
//        {
//            return;
//        }
//        if (head.rollNumber == rollNumber)
//        {
//            Console.WriteLine("Roll NUmber: " + head.rollNumber + " ,Name: " + head.name + " ,Age: " + head.age + " ,Grade: " + head.grade);
//            return;
//        }
//        Node temp = head;
//        while (temp != null)
//        {
//            if (temp.rollNumber == rollNumber)
//            {
//                Console.WriteLine("Roll NUmber: " + temp.rollNumber + " ,Name: " + temp.name + " ,Age: " + temp.age + " ,Grade: " + temp.grade);
//                return;
//            }
//            temp = temp.next;
//        }
//    }
//    //Update the rade value based on the roll number
//    public void UpdateGrade(int rollNumber, int grade)
//    {
//        if (head == null)
//        {
//            return;
//        }
//        //if (head.rollNumber == rollNumber)
//        //{
//        //    head.grade = grade;
//        //    return;
//        //}
//        Node temp = head;
//        while (temp != null)
//        {
//            if (temp.rollNumber == rollNumber)
//            {
//                temp.grade = grade;
//                return;
//            }
//            temp = temp.next;
//        }

//    }
//}

//public class Program
//{
//    static void Main(string[] args)
//    {
//        LinkedList list = new LinkedList();
//        list.Append(01, "Lakshay", 21, 12);
//        list.Append(02, "Shrey", 21, 12);
//        list.Append(03, "Prachi", 18, 12);
//        list.Append(04, "Riya", 23, 12);
//        list.Prepend(00, "Pallavi", 18, 12);
//        list.Display();
//        list.InsertAtIndex(01, "Thickie", 22, 12, 2);
//        Console.WriteLine("Displaying after adding at index");
//        list.Display();
//        list.DeleteRoll(01);
//        Console.WriteLine("Displlaying after deleting by roll number");
//        list.Display();
//        Console.WriteLine("Displaying by roll number");
//        list.DisplayRoll(04);
//        list.UpdateGrade(03, 11);
//        Console.WriteLine("After updating grade based on the roll number");
//        list.DisplayRoll(03);

//        Console.ReadKey();
//    }
//}
