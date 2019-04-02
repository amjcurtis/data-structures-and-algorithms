using System;
using System.Collections;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class Queue<T>
    {

        // Add Front property
        public Node<T> Front { get; set; }

        // Add Rear property
        public Node<T> Rear { get; set; }

        // Queue constructor
        public Queue(Node<T> node)
        {
            Front = node;
            Rear = node;
        }

        // Empty constructor (so can instantiate empty Queue)
        public Queue()
        {
        }

        /// <summary>
        /// Creates new node and enqueues at rear of queue
        /// </summary>
        /// <param name="value">integer value</param>
        public void Enqueue(T value)
        {
            Node<T> nodeToEnqueue = new Node<T>(value);
            Rear.Next = nodeToEnqueue;
            //nodeToEnqueue.Next = Rear;
            Rear = nodeToEnqueue;
        }


        /// <summary>
        /// Removes front node from queue
        /// </summary>
        /// <returns>dequeued node's value</returns>
        public Node<T> Dequeue()
        {
            Node<T> temp = Front;
            Front = Front.Next;
            temp.Next = null;
            return temp;
        }


        /// <summary>
        /// Looks at value of front node in queue
        /// </summary>
        /// <returns>value of front node in queue or null if queue is empty</returns>
        public Node<T> Peek()
        {
            return Front;
        }
    }
}
