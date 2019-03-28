using System;
using static LLMerge.Program;
using ConsoleApp_LinkedList.Classes;
using Xunit;

namespace XUnitTests_LLMerge
{
    public class UnitTests_LinkedListMerge
    {
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
    }
}
