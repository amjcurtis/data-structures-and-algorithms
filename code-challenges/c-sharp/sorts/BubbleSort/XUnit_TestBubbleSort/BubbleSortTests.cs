using BubbleSort;
using System;
using Xunit;

namespace XUnit_TestBubbleSort
{
	public class BubbleSortTests
	{
		[Fact]
		public void CanSortUnsortedArray()
		{
			// Arrange
			int[] nums = new int[] { 7, 4, 3, 9, 8, 6, 2, 1, 5 };

			// Act
			Program.BubbleSort(nums);

			// Assert
			Assert.Equal(9, nums[nums.Length - 1]);
		}

		[Fact]
		public void CanReturnAlreadySortedArray()
		{
			// Arrange
			int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

			// Act
			Program.BubbleSort(nums);

			// Assert
			Assert.Equal(9, nums[nums.Length - 1]);
		}

		[Fact]
		public void CanSortBackwardSortedArray()
		{
			// Arrange
			int[] nums = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 };

			// Act
			Program.BubbleSort(nums);

			// Assert
			Assert.Equal(9, nums[nums.Length - 1]);
		}

		[Fact]
		public void CanHandleEmptyArray()
		{
			// Arrange
			int[] nums = new int[0];

			// Act
			Program.BubbleSort(nums);

			// Assert
			Assert.Empty(nums);
		}

		[Fact]
		public void CanSortArrayOfOneElement()
		{
			// Arrange
			int[] nums = new int[] { 9 };

			// Act
			Program.BubbleSort(nums);

			// Assert
			Assert.Equal(9, nums[nums.Length - 1]);
		}

		[Fact]
		public void CanSortArrayWithDuplicateValues()
		{
			// Arrange
			int[] nums = new int[] { 7, 4, 3, 9, 9, 8, 6, 2, 1, 5 };

			// Act
			Program.BubbleSort(nums);

			// Assert
			Assert.Equal(9, nums[nums.Length - 2]);
		}
	}
}
