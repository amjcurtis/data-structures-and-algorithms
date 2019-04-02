using System;
using StacksAndQueues.Classes;

namespace StacksAndQueues
{
    public class Program
    {

        /// <summary>
        /// Main method for program
        /// </summary>
        /// <param name="args">string[] args</param>
        static void Main(string[] args)
        {
            //try
            //{
                // Instantiate generic Stack of int Nodes
                Node<int> intNode = new Node<int>(21);
                Stack<int> myStack = new Stack<int>(intNode);
                for (int i = 0; i < 6; i++)
                {
                    myStack.Push(i + 1);
                }
                Console.WriteLine($"myStack.Top: {myStack.Top.Value}");

                myStack.Pop();
                myStack.Pop();
                myStack.Pop();
                myStack.Pop();
                myStack.Pop();
                Node<int> valOfPoppedNode = myStack.Pop();
                Console.WriteLine($"Value of popped node: {valOfPoppedNode.Value}");

                Node<int> valOfPeekedTopNode = myStack.Peek();
                Console.WriteLine($"Val of peeked node: {valOfPeekedTopNode.Value}");


                Node<int> newNode = new Node<int>(1);
                Queue<int> myQueue = new Queue<int>(newNode);
                for (int i = 0; i < 6; i++)
                {
                    myQueue.Enqueue(i + 1);
                }
                Console.WriteLine($"myQueue.Rear: {myQueue.Rear.Value}");

                Node<int> valOfDequeuedNode = myQueue.Dequeue();
                Console.WriteLine($"myQueue.Front: {valOfDequeuedNode.Value}");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            Console.ReadLine();
        }
    }
}
