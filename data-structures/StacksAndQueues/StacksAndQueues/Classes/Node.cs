using System;
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
