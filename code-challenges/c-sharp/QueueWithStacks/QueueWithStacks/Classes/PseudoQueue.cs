using System;
using StacksAndQueues.Classes;
using System.Text;

namespace QueueWithStacks.Classes
{
    public class PseudoQueue<T>
    {
        // Publicly accessible stack
        public Stack<T> Stack1 { get; set; }

        // PseudoQueue constructor
        public PseudoQueue()
        {
            Stack1 = new Stack<T>();
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
        }


        /// <summary>
        /// Simulates queue's Dequeue method by removing bottom node from stack
        /// </summary>
        /// <returns>dequeued node</returns>
        public Node<T> Dequeue()
        {
            // Instantiate a second stack (empty) inside Dequeue b/c no need for it outside the method
            Stack<T> Stack2 = new Stack<T>();

            Node<T> temp;
            Node<T> tempToMove;

            // Can assume Stack2 is empty b/c it was just instantiated empty above, so no need to check first if Stack2 is empty
            while (Stack1.Top != null)
            {

                tempToMove = Stack1.Pop();
                Stack2.Push(tempToMove.Value);
            }
            // Holds bottom node of stack
            temp = Stack2.Pop();

            // Logic for resetting Stack1
            while (Stack2.Top != null)
            {
                tempToMove = Stack2.Pop();
                Stack1.Push(tempToMove.Value);
            }
            
            // After stack 1 is reset, *then* return temp
            return temp;
        }
    }
}
