using System;
using System.Collections;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class Stack<T> : IEnumerable
    {

        // Add Top property
        public Node<T> Top { get; set; }


        /// <summary>
        /// Creates new node and pushes to top of stack
        /// </summary>
        /// <param name="value">integer value</param>
        public void Push(int value)
        {
            Node<T> nodeToAdd = new Node<T>(value);
            nodeToAdd.Next = Top;
            Top = nodeToAdd;
        }


        /// <summary>
        /// Removes top node from stack
        /// </summary>
        /// <returns>popped node's value</returns>
        public int Pop()
        {
            Node<T> temp = Top;
            Top = Top.Next;
            temp.Next = null;
            return temp.Value;
        }


        /// <summary>
        /// Looks at value of top node in stack
        /// </summary>
        /// <returns>value of top node in stack or null if stack is empty</returns>
        public int Peek()
        {
            return Top.Value;
        }

        /// <summary>
        /// Implements IEnumerable
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Implements IEnumerable
        /// </summary>
        /// <returns>GetEumerator()</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
