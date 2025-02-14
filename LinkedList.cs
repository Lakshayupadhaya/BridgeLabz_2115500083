using System;

class LinkedList
{
	class Node
	{
		public string data;
		public Node next;
		
		public Node(string data)
		{
			this.data = data;
			this.next = null;
		}
	}
	private Node head;
	
	public void Print()
	{
		Node temp = head;
		while(temp != null)
		{
			Console.Write(temp.data + " -> ");
			temp = temp.next;
		}
		Console.WriteLine("null");
	}
		
	public void Sort()
	{
		int length = 0;
		Node current = head;
		while(current != null)
		{
			length++;
			current = current.next;
		}
		//Console.WriteLine(length);
		
		for(int i=0; i<length-1; i++)
		{
			Node temp = head;
			//bool flag =true;
			for(int j=0; j<length-i-1; j++)
			{
				if(temp.next.data[0] < temp.data[0])
				{
					string tempstring = temp.data;
					temp.data = temp.next.data;
					temp.next.data = tempstring;
				}
				temp = temp.next;
			}
			
		}
	}
	
	public static void Main()
	{
		LinkedList list = new LinkedList();
		list.head = new Node("Lakshay");
		list.head.next = new Node("Prachi");
		list.head.next.next = new Node("Shrey");
		list.head.next.next.next = new Node("Riya");
		list.Print();
		Console.WriteLine("After Sorting");
		list.Sort();
		list.Print();
		
		
	}
}