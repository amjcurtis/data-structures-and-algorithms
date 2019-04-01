using System;
using StacksAndQueues.Classes;

namespace StacksAndQueues
{
    class Program
    {

        /// <summary>
        /// Main method for program
        /// </summary>
        /// <param name="args">string[] args</param>
        static void Main(string[] args)
        {
            // Instantiate generic Stack of int Nodes
            Stack<Node<int>> myStack = new Stack<Node<int>>();
            for (int i = 0; i < 6; i++)
            {
                myStack.Push(i + 1);
            }
            Console.WriteLine($"myStack.Top: {myStack.Top.Value}");

            int valOfPoppedNode = myStack.Pop();
            Console.WriteLine($"Value of popped node: {valOfPoppedNode}");

            int valOfPeekedTopNode = myStack.Peek();
            Console.WriteLine($"Val of peeked node: {valOfPeekedTopNode}");
        }
    }
}
