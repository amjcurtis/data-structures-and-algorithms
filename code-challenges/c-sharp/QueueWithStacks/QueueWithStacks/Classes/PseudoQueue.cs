using System;
using StacksAndQueues.Classes;
using System.Text;

namespace QueueWithStacks.Classes
{
    public class PseudoQueue<T>
    {

        public Node<T> Front { get; set; }

        public Node<T> Rear { get; set; }

        public Stack<T> Stack1 { get; set; }

        public Stack<T> Stack2 { get; set; }

        // PseudoQueue constructor
        public PseudoQueue(Node<T> node)
        {
            Front = node;
            Rear = node;
            
            // Instantiate two empty stacks
            Stack<T> Stack1 = new Stack<T>(node);
            Stack<T> Stack2 = new Stack<T>();
        }

        // Empty constructor (so can instantiate empty PseudoQueue)
        public PseudoQueue()
        {
        }


        /// <summary>
        /// Simulates queue's Enqueue method by creating new node and pushing to bottom of stack
        /// </summary>
        /// <param name="value">value of any type</param>
        public void Enqueue(T value)
        {
            Stack1.Push(value);
            
            // OR the below?
            //Node<T> newNode = new Node<T>(value);
            //Stack1.Push(newNode.Value);
            

            // Queue's Enqueue method
            //Node<T> nodeToEnqueue = new Node<T>(value);
            //Rear.Next = nodeToEnqueue;
            //Rear = nodeToEnqueue;
        }


        /// <summary>
        /// Simulates queue's Dequeue method by removing bottom node from stack
        /// </summary>
        /// <returns>dequeued node</returns>
        public Node<T> Dequeue()
        {
            while (Stack1.Top != null)
            {
                Node<T> current = Stack1.Pop();
                Stack2.Push(current.Value);
            }
            Node<T> temp = Stack1.Peek();
            Stack1.Pop();
            while (Stack2.Top != null)
            {
                Node<T> current = Stack2.Pop();
                Stack1.Push(current.Value);
            }
            return temp;

            // Queue's Dequeue method
            //Node<T> temp = Front;
            //Front = Front.Next;
            //temp.Next = null;
            //return temp;
        }

    }
}
