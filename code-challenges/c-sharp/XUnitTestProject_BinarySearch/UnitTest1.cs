using BinarySearch;
using Xunit;

namespace XUnitTestProject_BinarySearch
{
    public class UnitTest1
    {
        /// <summary>
        /// Tests whether BinarySearch method correctly returns index of key if present in array
        /// </summary>
        [Fact]
        public void CanReturnCorrectIndexIfKeyFoundInArray()
        {
            // Arrange
            int[] sortedInputArray = { 4, 8, 15, 16, 19, 20, 23, 26, 29, 34, 39, 42 };

            // Act
            int result = Program.BinarySearch(sortedInputArray, 15);

            // Assert
            Assert.Equal(2, result);
        }

        /// <summary>
        /// Tests whether BinarySearch method returns index -1 if key not present in array
        /// </summary>
        [Fact]
        public void CanReturnNegativeOneIfKeyNotFoundInArray()
        {
            // Arrange
            int[] sortedInputArray = { 4, 8, 15, 16, 19, 20, 23, 26, 29, 34, 39, 42 };

            // Act
            int result = Program.BinarySearch(sortedInputArray, 14);

            // Assert
            Assert.Equal(-1, result);
        }
    }
}
