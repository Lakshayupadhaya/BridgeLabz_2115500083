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
    private Element queue;// it will act as a top for Queue
    public int length;

    public void Push(int data)
    {
        Element element = new Element(data);
        if (top == null)
        {
            top = element;
            queue = element;
            length++;
            //Console.WriteLine("Length: " + length);

            return;
        }
        //Element element = new Element(data);
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

    public void Queue(int data) 
    {
        //Element element = new Element(data);
        //if (top == null)
        //{
        //    top = element;
        //    queue = element;
        //    length++;
        //    //Console.WriteLine("Length: " + length);

        //    return;
        //}
        ////Element element = new Element(data);
        //element.next = top;
        //top = element;
        //length++;
        ////Console.WriteLine("Length: " + length);
        Push(data);
    }

    public void Deque() 
    {
        Stack stack2 = new Stack();
        Element temp = top;
        while(temp != null) 
        {
            stack2.Push(temp.data);
            temp = temp.next;

        }
        stack
    }
    public int Peek()
    {
        if (top == null)
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

    

}
