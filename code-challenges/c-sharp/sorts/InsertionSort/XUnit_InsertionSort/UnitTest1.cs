using Xunit;
using InsertionSort;

namespace XUnit_InsertionSort
{
	public class UnitTest_InsertionSort
	{
		[Fact]
		public void CanSortUnsortedArray()
		{
			// Arrange
			int[] array = new int[] { 4, 3, 1, 8, 5, 7, 2 };

			// Act
			int[] sortedArray = Program.InsertionSort(array);

			// Assert
			Assert.Equal(7, sortedArray[5]);
		}

		[Fact]
		public void CanReturnAlreadySortedArray()
		{
			// Arrange
			int[] array = new int[] { 1, 2, 3, 4, 5, 7, 8 };

			// Act
			int[] sortedArray = Program.InsertionSort(array);

			// Assert
			Assert.Equal(7, sortedArray[5]);
		}

		[Fact]
		public void CanSortBackwardSortedArray()
		{
			// Arrange
			int[] array = new int[] { 8, 7, 5, 4, 3, 2, 1 };

			// Act
			int[] sortedArray = Program.InsertionSort(array);

			// Assert
			Assert.Equal(8, sortedArray[6]);
		}

		[Fact]
		public void CanReturnEmptyArray()
		{
			// Arrange
			int[] array = new int[0];

			// Act
			int[] sortedArray = Program.InsertionSort(array);

			// Assert
			Assert.Empty(sortedArray);
		}

		[Fact]
		public void CanReturnArrayOfOneElement()
		{
			// Arrange
			int[] array = new int[] { 77 };

			// Act
			int[] singleElementArray = Program.InsertionSort(array);

			// Assert
			Assert.Equal(77, singleElementArray[0]);
		}
	}
}
