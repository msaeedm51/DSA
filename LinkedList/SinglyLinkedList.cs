public class Node
{
    public int Data { get; set; }
    public Node Next { get; set; }

    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}

public class LinkedList
{

    private Node head;

    public LinkedList()
    {
        head = null;
    }

     // Insert at the End of Linked List
    public void Append(int data)
    {
        Node newNode = new Node(data);

        if (head == null)
        {
            head = newNode;
            return;
        }

        Node current = head;
        while (current.Next != null)
        {
             current = current.Next;
        }

        current.Next = newNode;

    }

    public void Prepend(int data)
    {
        Node newNode = new Node(data);
        newNode.Next = head;
        head = newNode;
    }

    public void Delete(int data)
    {
        if(head == null) return;

        if(head.Data == data)
        {
            head = head.Next;
        }

        Node currentNode = head;
        while(currentNode.Next != null && currentNode.Next.Data != data)
        {
            currentNode = currentNode.Next;
        }

        if(currentNode.Next == null) return;

        currentNode.Next = currentNode.Next.Next;
    }

    public void InsertAfter(int data, int indexData)
    {
       Node currentNode = head;

       while(currentNode != null && currentNode.Data != indexData)
       {
          currentNode = currentNode.Next;
       }

       if(currentNode == null) 
       {
         Console.WriteLine("Target node not found.");
          return;
       }

       Node newNode = new Node(data);
       newNode.Next = currentNode.Next;
       currentNode.Next = newNode;
    }

    

}