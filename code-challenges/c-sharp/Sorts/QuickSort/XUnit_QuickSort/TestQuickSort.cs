using QuickSort;
using Xunit;

namespace XUnit_QuickSort
{
	public class UnitTest_QuickSort
	{
		[Fact]
		public void CanSortUnsortedArray()
		{
			// Arrange
			int[] nums = new int[] { 7, 4, 3, 9, 8, 6, 2, 1, 5 };

			// Act
			Program.QuickSort(nums, 0, nums.Length - 1);

			// Assert
			Assert.Equal(9, nums[nums.Length - 1]);
		}

		[Fact]
		public void CanReturnAlreadySortedArray()
		{
			// Arrange
			int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

			// Act
			Program.QuickSort(nums, 0, nums.Length - 1);

			// Assert
			Assert.Equal(9, nums[nums.Length - 1]);
		}

		[Fact]
		public void CanSortBackwardSortedArray()
		{
			// Arrange
			int[] nums = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 };

			// Act
			Program.QuickSort(nums, 0, nums.Length - 1);

			// Assert
			Assert.Equal(9, nums[nums.Length - 1]);
		}

		[Fact]
		public void CanHandleEmptyArray()
		{
			// Arrange
			int[] nums = new int[0];

			// Act
			Program.QuickSort(nums, 0, nums.Length - 1);

			// Assert
			Assert.Empty(nums);
		}

		[Fact]
		public void CanSortArrayOfOneElement()
		{
			// Arrange
			int[] nums = new int[] { 9 };

			// Act
			Program.QuickSort(nums, 0, nums.Length - 1);

			// Assert
			Assert.Equal(9, nums[nums.Length - 1]);
		}

		[Fact]
		public void CanSortArrayWithDuplicateValues()
		{
			// Arrange
			int[] nums = new int[] { 7, 4, 3, 9, 9, 8, 6, 2, 1, 5 };

			// Act
			Program.QuickSort(nums, 0, nums.Length - 1);

			// Assert
			Assert.Equal(9, nums[nums.Length - 2]);
		}
	}
}
