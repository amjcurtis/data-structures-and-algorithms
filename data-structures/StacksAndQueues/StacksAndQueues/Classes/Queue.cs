using System;
using System.Collections;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class Queue<T> : IEnumerable
    {

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
            Node<T> nodeToEnqueue = new Node<T>(value);
            //Rear.Next = nodeToEnqueue;
            nodeToEnqueue.Next = Rear;
            Rear = nodeToEnqueue;
        }


        /// <summary>
        /// Removes front node from queue
        /// </summary>
        /// <returns>dequeued node's value</returns>
        public int Dequeue()
        {
            Node<T> temp = Front;
            Front = Front.Next;
            temp.Next = null;
            return temp.Value;
        }


        /// <summary>
        /// Looks at value of front node in queue
        /// </summary>
        /// <returns>value of front node in queue or null if queue is empty</returns>
        public int Peek()
        {
            return Front.Value;
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
