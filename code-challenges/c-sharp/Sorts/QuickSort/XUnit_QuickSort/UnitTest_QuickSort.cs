using QuickSort;
using Xunit;

namespace XUnit_QuickSort
{
	public class UnitTest_QuickSort
	{
		
		/// <summary>
		/// Tests "happy path" of successfully sorting an array
		/// </summary>
		[Fact]
		public void CanSortArray()
		{
			// Arrange
			int[] myArray = new int[] { 6, 3, 2, 5, 9, 4, 7, 1, 8 };

			// Act
			Program.QuickSort(myArray, 0, myArray.Length - 1);

			// Assert
			Assert.Equal(1, myArray[0]);
		}

		/// <summary>
		/// Tests whether can sort an array of only one element
		/// </summary>
		[Fact]
		public void CanSortArrayOfOneElement()
		{
			// Arrange
			int[] myArray = new int[] { 6 };

			// Act
			Program.QuickSort(myArray, 0, myArray.Length - 1);

			// Assert
			Assert.Equal(6, myArray[0]);
		}
	}
}
