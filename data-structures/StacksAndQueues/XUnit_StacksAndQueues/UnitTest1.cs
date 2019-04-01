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

        [Fact]
        public void CanPeekTopNode()
        {
            // Arrange
            Stack<Node<int>> myStack = new Stack<Node<int>>();
            myStack.Push(12);

            // Act
            int valOfPeekedTopNode = myStack.Peek();

            // Assert
            Assert.Equal(12, valOfPeekedTopNode);
        }
    }
}
