public class Node
{
    public int Data { get; set; }
    public Node Prev { get; set; }
    public Node Next { get; set; }

    public Node(int data)
    {
        Data = data;
        Prev = null;
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

    public void Append(int data)
    {
        Node newNode = new Node(data);

        if (head == null)
        {
            head = newNode;
            return;
        }

        Node currentNode = head;
        while (currentNode.Next != null)
        {
            currentNode = currentNode.Next;
        }

        currentNode.Next = newNode;
        newNode.Prev = currentNode;

    }

    public void Prepend(int data)
    {
        Node newNode = new Node(data);

        if (head != null)
        {
            head.Prev = newNode;
        }

        newNode.Next = head;
        head = newNode;

    }



}
