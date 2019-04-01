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

        }

    }
}
