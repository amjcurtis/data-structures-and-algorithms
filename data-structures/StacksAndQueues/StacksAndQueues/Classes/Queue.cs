using System;
using System.Collections;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class Queue<T> : IEnumerable
    {

        // Add Top property
        public Node<T> Top { get; set; }

        // Add Front property
        public Node<T> Front { get; set; }

        // Add Rear property
        public Node<T> Rear { get; set; }

        /// <summary>
        /// Creates new node and enqueues at rear of queue
        /// </summary>
        /// <param name="value">integer value</param>
        public void Enqueue(int value)
        {
            Node<T> nodeToAdd = new Node<T>(value);
            Rear.Next = nodeToAdd;
            Rear = nodeToAdd;
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
