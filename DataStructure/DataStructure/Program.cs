using System;

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
        }
    }
}
