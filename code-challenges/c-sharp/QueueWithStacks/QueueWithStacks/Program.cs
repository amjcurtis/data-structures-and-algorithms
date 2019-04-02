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
            PseudoQueue<int> pseudoQueue = new PseudoQueue<int>();

            for (int i = 0; i < 6; i++)
            {
                pseudoQueue.Enqueue(i + 1);
            }
            //Console.WriteLine($"pseudoQueue.Front: {pseudoQueue.Top}");
            Console.WriteLine($"Value of pseudoQueue.Dequeue(): {pseudoQueue.Dequeue().Value}");
            Console.ReadLine();
        }
    }
}
