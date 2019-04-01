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
        /// Tests Stack's Push method for multiple successive nodes
        /// </summary>
        [Fact]
        public void CanPushMultipeNodeSToStack()
        {
            // Arrange
            Stack<Node<int>> myStack = new Stack<Node<int>>();

            // Act
            myStack.Push(25);
            myStack.Push(16);

            // Assert
            Assert.Equal(16, myStack.Top.Value);
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
        /// Tests Stack's Pop method's ability to pop all nodes off stack
        /// </summary>
        [Fact]
        public void CanPopAllNodesFromStack()
        {
            // Arrange
            Stack<Node<int>> myStack = new Stack<Node<int>>();
            myStack.Push(12);
            myStack.Push(25);

            // Act
            myStack.Pop();
            myStack.Pop();

            // Assert
            Assert.Null(myStack.Top);
        }

        /// <summary>
        /// Tests whether can instantiate an empty stack
        /// </summary>
        [Fact]
        public void CanInstantiateEmptyStack()
        {
            // Act
            Stack<Node<int>> myStack = new Stack<Node<int>>();

            // Assert
            Assert.Null(myStack.Top);
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
        /// Tests Queue's Enqueue method can enqueue multiple nodes
        /// </summary>
        [Fact]
        public void CanEnqueueMultipleNodesInQueue()
        {
            // Arrange
            Queue<Node<int>> myQueue = new Queue<Node<int>>();

            // Act
            myQueue.Enqueue(20);
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
        /// Tests Queue's Dequeue method can empty a queue
        /// </summary>
        [Fact]
        public void CanDequeueAllNodesFromQueue()
        {
            // Arrange
            Queue<Node<int>> myQueue = new Queue<Node<int>>();
            myQueue.Enqueue(25);
            myQueue.Enqueue(16);

            // Act
            myQueue.Dequeue();
            myQueue.Dequeue();

            // Assert
            Assert.Null(myQueue.Front);
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

        /// <summary>
        /// Tests whether can instantiate empty queue
        /// </summary>
        [Fact]
        public void CanInstantiateEmptyQueue()
        {
            // Act
            Queue<Node<int>> myQueue = new Queue<Node<int>>();

            // Assert
            Assert.Null(myQueue.Front);
        }
    }
}
