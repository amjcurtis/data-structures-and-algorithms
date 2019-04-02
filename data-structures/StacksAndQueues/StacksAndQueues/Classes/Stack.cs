using System;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class Stack<T>
    {

        public Node<T> Top { get; set; }

        // Stack constructor
        public Stack(Node<T> node)
        {
            Top = node;
        }
        
        // Empty constructor (so can instantiate empty Stack)
        public Stack()
        {
        }

        /// <summary>
        /// Creates new node and pushes to top of stack
        /// </summary>
        /// <param name="value">value of any type</param>
        public void Push(T value)
        {
            Node<T> nodeToAdd = new Node<T>(value);
            nodeToAdd.Next = Top;
            Top = nodeToAdd;
        }

        /// <summary>
        /// Removes top node from stack
        /// </summary>
        /// <returns>popped node's value</returns>
        public Node<T> Pop()
        {
            Node<T> temp = Top;
            Top = Top.Next;
            temp.Next = null;
            return temp;
        }

        /// <summary>
        /// Looks at value of top node in stack
        /// </summary>
        /// <returns>value of top node in stack or null if stack is empty</returns>
        public Node<T> Peek()
        {
            return Top;
        }
    }
}
