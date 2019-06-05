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
			Program.InsertionSort(array);

			// Assert
			Assert.Equal(7, array[5]);
		}

		[Fact]
		public void CanReturnAlreadySortedArray()
		{
			// Arrange
			int[] sortedArray = new int[] { 1, 2, 3, 4, 5, 7, 8 };

			// Act
			Program.InsertionSort(sortedArray);

			// Assert
			Assert.Equal(7, sortedArray[5]);
		}

		[Fact]
		public void CanSortBackwardSortedArray()
		{
			// Arrange
			int[] backwardSortedArray = new int[] { 8, 7, 5, 4, 3, 2, 1 };

			// Act
			Program.InsertionSort(backwardSortedArray);

			// Assert
			Assert.Equal(8, backwardSortedArray[6]);
		}

		[Fact]
		public void CanHandleEmptyArray()
		{
			// Arrange
			int[] emptyArray = new int[0];

			// Act
			Program.InsertionSort(emptyArray);

			// Assert
			Assert.Empty(emptyArray);
		}

		[Fact]
		public void CanSortArrayOfOneElement()
		{
			// Arrange
			int[] singleElementArray = new int[] { 77 };

			// Act
			Program.InsertionSort(singleElementArray);

			// Assert
			Assert.Equal(77, singleElementArray[0]);
		}

		[Fact]
		public void CanSortArrayWithDuplicateValues()
		{
			// Arrange
			int[] array = new int[] { 4, 3, 1, 7, 8, 5, 7, 2 };

			// Act
			Program.InsertionSort(array);

			// Assert
			Assert.Equal(7, array[array.Length - 3]);
		}
	}
}
