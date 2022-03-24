﻿using System;

namespace DataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedLists linkedList = new LinkedLists();
            Node node_1 = new Node(1);
            Node node_2 = new Node(2);
            Node node_3 = new Node(3);

            linkedList.AddNode(node_1);
            linkedList.AddNode(node_2);
            linkedList.AddNode(node_3);
            linkedList.Display();
            
            linkedList.AppendNode(23);
            linkedList.Display();
            
            linkedList.AddNodeAtStart(20);
            linkedList.Display();

            linkedList.DeleteNodeAtFirst();
            linkedList.Display();

            linkedList.DeleteEndNode();
            linkedList.Display();

            Console.WriteLine("Enter number to search");
            int data = int.Parse(Console.ReadLine());
            if (linkedList.Search(data) != null)
            {
                Console.WriteLine("Node found");
            }
            else
            {
                Console.WriteLine("Node not found");
            }

        }
    }
}
