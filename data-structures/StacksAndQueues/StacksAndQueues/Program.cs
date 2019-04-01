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
            Classes.Stack<Node<int>> stack = new Classes.Stack<Node<int>>();

            Node<int> testNode = new Node<int>(12);

            Console.WriteLine(testNode.Value);
        }
    }
}
