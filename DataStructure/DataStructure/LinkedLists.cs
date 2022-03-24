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
                System.Console.WriteLine("Linked list is Empty");
            }
            else
            {
                System.Console.WriteLine("Elements are");
                while (temp != null)
                {
                    System.Console.Write(temp.data);
                    if (temp.next != null)
                    {
                        System.Console.WriteLine(" ");
                    }
                    temp = temp.next;
                }
            }
            Console.WriteLine();
        }
    }
}