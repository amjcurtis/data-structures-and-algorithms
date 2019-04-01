using System;
using StacksAndQueues.Classes;
using Xunit;

namespace XUnit_StacksAndQueues
{
    public class UnitTest_StacksAndQueues
    {
        /// <summary>
        /// Tests Stack's Push method
        /// </summary>
        [Fact]
        public void CanPushNodeToStack()
        {
            // Arrange
            Stack<Node<int>> myStack = new Stack<Node<int>>();
            
            // Act
            myStack.Push(25);

            // Assert
            Assert.Equal(25, myStack.Top.Value);
        }

        /// <summary>
        /// Tests Stack's Pop method
        /// </summary>
        [Fact]
        public void CanPopNodeFromStack()
        {
            // Arrange
            Stack<Node<int>> myStack = new Stack<Node<int>>();
            myStack.Push(12);
            myStack.Push(25);

            // Act
            int poppedValue = myStack.Pop();

            // Assert
            Assert.Equal(25, poppedValue);
        }

        /// <summary>
        /// Tests Stack's Peek method
        /// </summary>
        [Fact]
        public void CanPeekTopNodeInStack()
        {
            // Arrange
            Stack<Node<int>> myStack = new Stack<Node<int>>();
            myStack.Push(12);

            // Act
            int valOfPeekedTopNode = myStack.Peek();

            // Assert
            Assert.Equal(12, valOfPeekedTopNode);
        }

        /// <summary>
        /// Tests Queue's Enqueue method
        /// </summary>
        [Fact]
        public void CanEnqueueNodeInQueue()
        {
            // Arrange
            Queue<Node<int>> myQueue = new Queue<Node<int>>();

            // Act
            myQueue.Enqueue(13);

            // Assert
            Assert.Equal(13, myQueue.Rear.Value);
        }

        /// <summary>
        /// Tests Queue's Dequeue method
        /// </summary>
        [Fact]
        public void CanDequeueNodeFromQueue()
        {
            // Arrange
            Queue<Node<int>> myQueue = new Queue<Node<int>>();
            myQueue.Enqueue(25);
            myQueue.Enqueue(16);

            // Act
            int valOfDequeuedNode = myQueue.Dequeue();

            // Assert
            Assert.Equal(25, valOfDequeuedNode);
        }

        /// <summary>
        /// Tests Queue's Peek method
        /// </summary>
        [Fact]
        public void CanPeekFrontNodeInQueue()
        {
            // Arrange
            Queue<Node<int>> myQueue = new Queue<Node<int>>();
            myQueue.Enqueue(25);

            // Act
            int valOfPeekedFrontNode = myQueue.Peek();

            // Assert
            Assert.Equal(25, valOfPeekedFrontNode);
        }
    }
}
