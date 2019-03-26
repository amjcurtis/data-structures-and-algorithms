using ConsoleApp_LinkedList.Classes;
using System;
using Xunit;

namespace XUnitTestProject_SinglyLinkedList
{
    public class UnitTest_SinglyLinkedList
    {
        /// <summary>
        /// Tests successful instantiation of empty linked list
        /// </summary>
        [Fact]
        public void CanInstantiateEmptyLinkedList()
        {
            // Act
            LList myLinkedList = new LList();

            // Assert
            Assert.NotNull(myLinkedList);
        }

        /// <summary>
        /// Tests successful insertion of new node at beginning of linked list
        /// </summary>
        [Fact]
        public void CanInsertNodeIntoLinkedList()
        {
            // Arrange
            LList newList = new LList();

            // Act
            newList.Insert(12);

            // Assert
            Assert.Equal(12, newList.Head.Value);
        }

        /// <summary>
        /// Tests whether Head node is sole node in list and whether its value is expected value
        /// </summary>
        [Fact]
        public void DoesHeadPointToFirstNode()
        {
            // Arrange
            LList newList = new LList();

            // Act
            // Insert single node into list
            newList.Insert(114);

            // Assert
            // Check whether Head node is the only node in list
            Assert.Null(newList.Head.Next);
            // Check whether value of the list's single node equals value of node's Head
            Assert.Equal(114, newList.Head.Value);
        }

        /// <summary>
        /// Tests presence of multiple nodes in list by verifying Head node's Next is not null
        /// </summary>
        [Fact]
        public void CanInsertMultipleNodesIntoList()
        {
            // Arrange
            LList newList = new LList();

            // Act
            newList.Insert(7);
            newList.Insert(12);

            // Assert
            Assert.NotNull(newList.Head.Next);
        }

        /// <summary>
        /// Tests if returns true when finding a value present in list
        /// </summary>
        [Fact]
        public void CanVerifyValueExistsInList()
        {
            // Arrange
            LList newList = new LList();
            newList.Insert(5);
            newList.Insert(16);

            // Act
            bool listIncludesVal = newList.Includes(16);

            // Assert
            Assert.True(listIncludesVal);
        }

        /// <summary>
        /// Tests if returns false when checking for a value not present in list
        /// </summary>
        [Fact]
        public void CanVerifyValueNotExistsInList()
        {
            // Arrange
            LList newList = new LList();
            newList.Insert(5);
            newList.Insert(16);

            // Act
            bool listIncludesVal = newList.Includes(3);

            // Assert
            Assert.False(listIncludesVal);
        }

        /// <summary>
        /// Tests if Print() method returns array of all values in list
        /// </summary>
        /// <param name="index">index to check for value at</param>
        /// <param name="value">value to check for</param>
        [Theory]
        [InlineData(0, 3)]
        [InlineData(1, 2)]
        [InlineData(2, 1)]

        public void CanReturnArrayOfAllValuesInList(int index, int value)
        {
            // Arrange
            LList newList = new LList();
            for (int i = 0; i < 3; i++)
            {
                newList.Insert(i + 1);
            }

            // Act
            int[] printedVals = newList.Print();

            // Assert
            Assert.Equal(printedVals[index], value); 
        }
    }
}
