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
            Node<int> newNode = new Node<int>(16);
            Stack<int> myStack = new Stack<int>(newNode);
            
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
            Node<int> newNode = new Node<int>(16);
            Stack<int> myStack = new Stack<int>(newNode);

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
            Node<int> newNode = new Node<int>(14);
            Stack<int> myStack = new Stack<int>(newNode);
            myStack.Push(12);
            myStack.Push(25);

            // Act
            Node<int> poppedNode = myStack.Pop();

            // Assert
            Assert.Equal(25, poppedNode.Value);
        }
        
        /// <summary>
        /// Tests Stack's Pop method's ability to pop all nodes off stack
        /// </summary>
        [Fact]
        public void CanPopAllNodesFromStack()
        {
            // Arrange
            Node<int> newNode = new Node<int>(14);
            Stack<int> myStack = new Stack<int>(newNode);
            myStack.Push(12);
            myStack.Push(25);

            // Act
            myStack.Pop();
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
            Stack<int> myStack = new Stack<int>();

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
            Stack<int> myStack = new Stack<int>();
            myStack.Push(12);

            // Act
            Node<int> peekedTopNode = myStack.Peek();

            // Assert
            Assert.Equal(12, peekedTopNode.Value);
        }

        /// <summary>
        /// Tests Queue's Enqueue method
        /// </summary>
        [Fact]
        public void CanEnqueueNodeInQueue()
        {
            // Arrange
            Node<int> newNode = new Node<int>(13);
            Queue<int> myQueue = new Queue<int>(newNode);

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
            Node<int> newNode = new Node<int>(4);
            Queue<int> myQueue = new Queue<int>(newNode);

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
            Node<int> newNode = new Node<int>(4);
            Queue<int> myQueue = new Queue<int>(newNode);
            myQueue.Enqueue(25);

            // Act
            Node<int> dequeuedNode = myQueue.Dequeue();

            // Assert
            Assert.Equal(4, dequeuedNode.Value);
        }

        /// <summary>
        /// Tests Queue's Dequeue method can empty a queue
        /// </summary>
        [Fact]
        public void CanDequeueAllNodesFromQueue()
        {
            // Arrange
            Node<int> newNode = new Node<int>(4);
            Queue<int> myQueue = new Queue<int>(newNode);
            myQueue.Enqueue(25);

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
            Node<int> newNode = new Node<int>(4);
            Queue<int> myQueue = new Queue<int>(newNode);

            // Act
            Node<int> peekedFrontNode = myQueue.Peek();

            // Assert
            Assert.Equal(4, peekedFrontNode.Value);
        }
        
        /// <summary>
        /// Tests whether can instantiate empty queue
        /// </summary>
        [Fact]
        public void CanInstantiateEmptyQueue()
        {
            // Act
            Queue<int> myQueue = new Queue<int>();

            // Assert
            Assert.Null(myQueue.Front);
        }
    }
}
