﻿namespace ConsoleApp_LinkedList.Classes
{
    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }

        // Node constructor
        public Node(int value)
        {
            Value = value;
            Next = null;
        }
    }
}
