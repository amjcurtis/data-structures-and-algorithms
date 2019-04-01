using System;
using System.Collections.Generic;
using StacksAndQueues.Classes;

namespace StacksAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate generic Stack of int Nodes
            Classes.Stack<Node<int>> myStack = new Classes.Stack<Node<int>>();
            for (int i = 0; i < 6; i++)
            {
                myStack.Push(i + 1);
            }

            //myStack.Push(25);
            Console.WriteLine($"myStack.Top: {myStack.Top.Value}");

            //Node<int> testNode = new Node<int>(12);
            //Console.WriteLine(testNode.Value);
        }
    }
}
