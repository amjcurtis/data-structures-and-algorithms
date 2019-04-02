using System;
using QueueWithStacks.Classes;
using StacksAndQueues.Classes;


namespace QueueWithStacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Node<int> newNode = new Node<int>(21);
            PseudoQueue<int> pseudoQueue = new PseudoQueue<int>(newNode);

            for (int i = 0; i < 4; i++)
            {
                pseudoQueue.Enqueue(18);
            }
            Console.WriteLine($"pseudoQueue.Front: {pseudoQueue.Front}");
            Console.WriteLine($"Value of pseudoQueue.Dequeue(): {pseudoQueue.Dequeue()}");
        }
    }
}
