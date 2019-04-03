using System;
using QueueWithStacks.Classes;
using StacksAndQueues.Classes;
using Xunit;

namespace XUnitTest_QueueWithStacks
{
    public class TestQueueWithStacks
    {
        /// <summary>
        /// Tests whether can add simulate enqueuing node in queue using only stacks
        /// </summary>
        [Fact]
        public void CanEnqueueNodeOntoQueueWithStacks()
        {
            // Arrange
            PseudoQueue<int> pseudoQueue = new PseudoQueue<int>();

            // Act
            pseudoQueue.Enqueue(21);

            // Assert
            Assert.Equal(21, pseudoQueue.Dequeue().Value);
        }

        /// <summary>
        /// Tests whether can return null from dequeue method when run on empty stack
        /// </summary>
        [Fact]
        public void CanReturnNullFromDequeueOnEmptyStack()
        {
            // Arrange
            PseudoQueue<int> pseudoQueue = new PseudoQueue<int>();

            // Act
            //pseudoQueue.Enqueue(44);
            Node<int> dequeuedNode = pseudoQueue.Dequeue();

            // Assert
            Assert.Null(dequeuedNode);
        }
    }
}
