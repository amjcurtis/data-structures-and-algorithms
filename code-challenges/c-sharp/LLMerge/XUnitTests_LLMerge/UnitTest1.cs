using System;
using static LLMerge.Program;
using ConsoleApp_LinkedList.Classes;
using Xunit;

namespace XUnitTests_LLMerge
{
    public class UnitTests_LinkedListMerge
    {
        /// <summary>
        /// Tests that MergeLists method works as expected
        /// </summary>
        /// <param name="index">index of array of list node values</param>
        /// <param name="expectedValue">value expected at index of array of list nodes</param>
        [Theory]
        [InlineData(0,1)]
        [InlineData(1,11)]
        [InlineData(2,2)]
        [InlineData(3,12)]
        public void CanMergeLists(int index, int expectedValue)
        {
            // Arrange
            LList list1 = new LList();
            for (int i = 0; i < 3; i++)
            {
                list1.Append(i + 1);
            }
            
            LList list2 = new LList();
            for (int i = 0; i < 3; i++)
            {
                list2.Append(i + 11);
            }
            
            // Act
            LList zippedList = MergeLists(list1, list2);
            int[] printedZippedList = zippedList.Print();
            
            // Assert
            Assert.Equal(printedZippedList[index], expectedValue);
        }

        /// <summary>
        /// Tests whether can merge lists of unequal lengths
        /// </summary>
        /// <param name="lengthOfList1"></param>
        /// <param name="LengthOfList2"></param>
        /// <param name="index"></param>
        /// <param name="expectedValue"></param>
        [Theory]
        [InlineData(3, 6, 6, 14)]
        [InlineData(6, 3, 7, 5)]
        public void CanHandleListsOfUnequalLengths(int lengthOfList1, int LengthOfList2, int index, int expectedValue)
        {
            // Arrange
            LList list1 = new LList();
            for (int i = 0; i < lengthOfList1; i++)
            {
                list1.Append(i + 1);
            }

            LList list2 = new LList();
            for (int i = 0; i < LengthOfList2; i++)
            {
                list2.Append(i + 11);
            }

            // Act
            LList zippedList = MergeLists(list1, list2);
            int[] printedZippedList = zippedList.Print();

            // Assert
            Assert.Equal(printedZippedList[index], expectedValue);
        }

        /// <summary>
        /// Returns null if either of linked lists input as args is empty
        /// </summary>
        [Fact]
        public void CanHandleOneOrMoreEmptyList()
        {
            // Arrange
            LList list1 = new LList();

            LList list2 = new LList();
            for (int i = 0; i < 3; i++)
            {
                list2.Append(i + 1);
            }

            // Act
            LList zippedList = MergeLists(list1, list2);

            // Assert
            Assert.Equal(2, zippedList.Head.Next.Value);
            //Assert.Null(zippedList);
        }

    }
}
