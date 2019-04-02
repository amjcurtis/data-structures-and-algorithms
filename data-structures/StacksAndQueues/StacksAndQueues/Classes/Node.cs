using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class Node<T>
    {

        public T Value { get; set; }

        public Node<T> Next { get; set; }

        // Node constructor
        public Node(T value)
        {
            Value = value;
            Next = null;
        }
    }
}
