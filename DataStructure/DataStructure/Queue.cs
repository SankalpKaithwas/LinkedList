using System;
namespace DataStructure
{
    internal class Queue
    {
        LinkedLists linkedLists;

        public Queue()
        {
            linkedLists = new LinkedLists();
        }

        public void Enqueue(int data)
        {
            linkedLists.AppendNode(data);
        }
        public void DisplayQueue()
        {
            Console.WriteLine("Queue elements are -");
            linkedLists.Display();
        }

        public void Top()
        {
            var value = linkedLists.head;
            Console.WriteLine(value.data);
        }
        public void Dequeue()
        {
            linkedLists.DeleteNodeAtFirst();
        }
    }
}