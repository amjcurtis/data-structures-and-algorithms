using System;
using System.Collections;
using System.Collections.Generic;
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

        //TODO Pop method
        public int Pop()
        {
            Node<T> temp = Top;
            Top = Top.Next;
            temp.Next = null;
            return temp.Value;
        }

        //TODO Peek method 

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
