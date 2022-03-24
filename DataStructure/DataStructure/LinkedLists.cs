using System;
namespace DataStructure
{
    internal class LinkedLists
    {

        public Node head;
        public Node tail;

        public LinkedLists()
        {
            head = null;
            tail = null;
        }
        public void AddNode(Node node)
        {
            if (head == null && tail == null)
            {
                head = node;
                tail = node;
            }
            else
            {
                node.next = head;
                head = node;// make new node as head
            }
        }
        public void Display()
        {
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is Empty");
            }
            else
            {
                Console.WriteLine("Elements are");
                while (temp != null)
                {
                    Console.Write(temp.data);
                    if (temp.next != null)
                    {
                        Console.Write("-> ");
                    }
                    temp = temp.next;
                }
            }
            Console.WriteLine();
        }
        public void AppendNode(int data)
        {
            Node node = new Node(data);
            if (head == null) // if empty
            {
                head = tail = node;
            }
            else
            {
                tail.next = node;//add at end
                tail = node;//make new node as tail 
            }
        }
        public void AddNodeAtStart(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = tail = node;
            }
            else
            {
                node.next = head;
                head = node;
            }
        }
        public void DeleteNodeAtFirst()
        {
            if (this.head == null)
            {
                System.Console.WriteLine("List is empty");
            }
            else
            {
                Node temp = this.head;
                this.head = this.head.next;
                System.Console.WriteLine("Removed from list " + temp.data);
            }
        }
    }
}