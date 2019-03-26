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
            newList.Insert(12);

            // Assert
            // Check whether Head node is the only node in list
            Assert.Null(newList.Head.Next);
            // Check whether value of the list's single node equals value of node's Head
            Assert.Equal(12, newList.Head.Value);
        }

        // 4. Can properly insert multiple nodes into the linked list
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

        //// 5. Will return true when finding a value within the linked list that exists
        //[Fact]
        //public void Test1()
        //{

        //}

        //// 6. Will return false when searching for a value in the linked list that does not exist
        //[Fact]
        //public void Test1()
        //{

        //}

        //// 7. Can properly return a collection of all the values that exist in the linked list
        //[Fact]
        //public void Test1()
        //{

        //}
    }
}
