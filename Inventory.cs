using System;

public class Node
{
    public string itemName;
    public int itemId;
    public int quantity;
    public int price;
    public Node next;

    public Node(string itemName, int itemId, int quantity, int price)
    {
        this.itemName = itemName;
        this.itemId = itemId;
        this.quantity = quantity;
        this.price = price;
        this.next = null;
    }
}

public class LinkedList
{
    private Node head;

    public LinkedList()
    {
        head = null;
    }

    public void Append(string itemName, int itemId, int quantity, int price)
    {

        if (head == null)
        {
            head = new Node(itemName, itemId, quantity, price);
            return;
        }

        Node temp = head;
        while (temp.next != null)
        {
            temp = temp.next;
        }
        temp.next = new Node(itemName, itemId, quantity, price);
    }

    public void Prepend(string itemName, int itemId, int quantity, int price)
    {
        if (head == null)
        {
            head = new Node(itemName, itemId, quantity, price);
            return;
        }
        Node newNode = new Node(itemName, itemId, quantity, price);
        newNode.next = head;
        head = newNode;
    }

    public void Insert(string itemName, int itemId, int quantity, int price, int index)
    {
        if (head == null)
        {
            head = new Node(itemName, itemId, quantity, price);
            return;
        }
        if (index == 1)
        {
            Prepend(itemName, itemId, quantity, price);
            return;
        }
        int count = 1;
        Node current = head;
        while (count != index - 1)
        {
            current = current.next;
            count++;
        }
        Node newNode = new Node(itemName, itemId, quantity, price);
        Node node = current.next;
        current.next = newNode;
        newNode.next = node;
    }
    public void Display()
    {
        Node temp = head;
        while (temp != null)
        {
            Console.WriteLine(temp.itemName + " " + temp.itemId + " " + temp.quantity + " " + temp.price) ;
            temp = temp.next;
        }
    }
    public void DeleteId(int id) 
    {
        if(head == null) 
        {
            return;
        }
        if(head.itemId == id) 
        {
            head = head.next;
            return;
        }
        Node current = head;
        while (current != null) 
        {
            if(current.next.itemId == id) 
            {
                current.next = current.next.next;
                return;
            }
            current = current.next;
        }
    }
    public void IdUpdateQuantity(int id, int quantity) 
    {
        if (head == null)
        {
            return;
        }
        //if(head.itemId == id) 
        //{
        //    head.quantity = quantity;
        //}
        Node current = head;
        while(current != null) 
        {
            if(current.itemId == id) 
            {
                current.quantity = quantity;
                return;
            }
            current = current.next;
        }
    }
    public void DisplayItemNameId(int id) 
    {
        if (head == null) 
        {
            return;
        }
        //if(head.itemId == id) 
        //{
        //    Console.WriteLine(temp.itemName + " " + temp.itemId + " " + temp.quantity + " " + temp.price);
        //    return;
        //}
        Node current = head;
        while (current != null) 
        {
            if(current.itemId == id) 
            {
                Console.WriteLine(current.itemName + " " + current.itemId + " " + current.quantity + " " + current.price);
            }
            current = current.next;
        }

    }
    public void DisplayItemNameId(string name)
    {
        if (head == null)
        {
            return;
        }
        //if(head.name == name) 
        //{
        //    Console.WriteLine(temp.itemName + " " + temp.itemId + " " + temp.quantity + " " + temp.price);
        //    return;
        //}
        Node current = head;
        while (current != null)
        {
            if (current.itemName == name)
            {
                Console.WriteLine(current.itemName + " " + current.itemId + " " + current.quantity + " " + current.price);
            }
            current = current.next;
        }

    }

}

public class Program
{
    static void Main(string[] args)
    {
        LinkedList list = new LinkedList();
        list.Prepend("Based seasalt spray", 3562873, 2300, 2314);
        list.Append("Cerave", 0838472, 7300, 1500);
        list.Append("Dot & key", 0382635, 700, 2718);
        list.Insert("Bracelet", 2937263, 2715, 999, 2);
        list.Prepend("Airforce 1", 9283652, 23, 23017);
        list.Display();
        Console.WriteLine("After deleting by id");
        list.DeleteId(0382635);
        list.Display();
        Console.WriteLine("After updating quantity by id");
        list.IdUpdateQuantity(9283652, 10);
        list.Display();
        Console.WriteLine("Displaying product with both name or id user friendly");
        list.DisplayItemNameId(0838472);
        list.DisplayItemNameId("Cerave");


        Console.ReadKey();
    }
}
