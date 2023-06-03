// See https://aka.ms/new-console-template for more information


//Console.WriteLine("Hello, World!");

LinkList linkList = new LinkList();

linkList.AddNode(1);
linkList.AddNode(2);
linkList.AddNode(3);
linkList.AddNode(4);
linkList.AddNode(5);

Console.WriteLine("Initial list:");
linkList.PrintList(); // Spausdins: 1 2 3 4 5

linkList.DeleteNode(3); // ištriname skaičių 3 iš sąrašo

Console.WriteLine("\nList after deleting 3:");
linkList.PrintList(); // Spausdins: 1 2 4 5

// Link list class
public sealed class LinkList
{
    // Node class
    private sealed class Node
    {
        // Data where integer is stored
        public int Data { get; set; }
        // Reference to next node
        public Node Next { get; set; }

        // 
        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }
   

    private Node head; // Start of the list

    
    private Node tail;// End of the list

    // Constructor
    public LinkList()
    {
        this.head = null;
        this.tail = null;
    }

    // Method to add node to the list
    public void AddNode(int data)
    {
        // Create new node with data
        Node newNode = new Node(data);

        // If list is empty, new node is head and tail
        if (head == null)
        {
            head = newNode;
            tail = newNode;
        }
        // If list is not empty, add new node to the end of the list
        else
        {
            tail.Next = newNode;
            tail = newNode;
        }
    }

    // Delete node
    public void DeleteNode(int key)
    {
        
        Node temp = head, prev = null;

        // If need to remove head
        if (temp != null && temp.Data == key)
        {
            head = temp.Next; // Change head to next node
            return;
        }
        // Search for node to delete 
        while (temp != null && temp.Data != key)
        {
            prev = temp;
            temp = temp.Next;
        }
        // If node is not in the list
        if (temp == null) return;
        // delete node from the list
        prev.Next = temp.Next;
    }

    public void PrintList()
    {
        Node current = head;

        while (current != null)
        {
            Console.Write(current.Data + " ");
            current = current.Next;
        }
    }
}


