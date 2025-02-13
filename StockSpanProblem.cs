using System;

public class Stack
{
    public class Element
    {
        public int data;
        public Element next;

        public Element(int data)
        {
            this.data = data;
            this.next = null;
        }
    }


    private Element top;
    public int length;

    public void Push(int data)
    {
        //Element element = new Element(data);
        if (top == null)
        {
            top = new Element(data);
            length++;
            //Console.WriteLine("Length: " + length);

            return;
        }
        Element element = new Element(data);
        element.next = top;
        top = element;
        length++;
        //Console.WriteLine("Length: " + length);
    }

    public void Pop()
    {
        if (top == null)
        {
            Console.WriteLine("Stack is empty");
            return;
        }

        //Element temp = top;
        int element = top.data;
        top = top.next;


        //temp.next = temp.next.next;
        length--;
        //Console.WriteLine("Length: "+ length + " Element: " + element);
        //Console.WriteLine(element);
    }

    public int Peek()
    {
        if(top == null) 
        {
            return -1;
        }
        return top.data;
    }
    public int Length() 
    {
        return length;
    }

}

class Program
{
    public static void Main(string[] args)
    {
        int[] price = {10, 20, 30, 20, 12, 11, 23,  24, 25, 22, 21, 20, 12, 11, 10, 27};
        Stack stack = new Stack();
        int length = 0;
        if (price.Length != 0)
        {
            stack.Push(price[0]);
        }
        for (int i =1; i<price.Length; i++) 
        {
            if(stack.Peek()  == -1) 
            {
                stack.Push(price[i]);
            }
            else if(stack.Peek() > price[i]) 
            {
                stack.Push(price[i]);
                int stackLength = stack.Length();
                length = Math.Max(length, stackLength);
            }
            else if (stack.Peek() < price[i]) 
            {
                while(stack.Length() != 0) 
                {
                    stack.Pop();
                }
                
                stack.Push(price[i]);
                int stackLength = stack.Length();
                length = Math.Max(length, stackLength);
            }
            else 
            {
                while (stack.Length() != 0)
                {
                    stack.Pop();
                }
                int stackLength = stack.Length();
                length = Math.Max(length, stackLength);
            }
        }
        Console.WriteLine(length-1);//because it is also counting the very first day from when the price starts dropping (Go to 25 for reference)

    }
}
