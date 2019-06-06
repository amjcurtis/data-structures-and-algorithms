using System;

namespace MergeSort
{
	public class Program
	{
		static void Main(string[] args)
		{
			int[] nums = new int[] { 4, 7, 5, 3, 9, 6, 2, 8, 1 };

			// Print array before sorting
			for (int i = 0; i < nums.Length; i++)
			{
				Console.Write("{0} ", nums[i]);
			}
			Console.WriteLine();

			// Sort array
			int[] sortedNums = MergeSort(nums);

			// Print array after sorting
			for (int i = 0; i < sortedNums.Length; i++)
			{
				Console.Write("{0} ", sortedNums[i]);
			}
			Console.WriteLine();
		}

		/// <summary>
		/// Sorts array using recursive merge sort with O(n log n) runtime and O(n) space complexity
		/// </summary>
		/// <param name="arr">array to sort</param>
		/// <returns>same array, sorted</returns>
		public static int[] MergeSort(int[] arr)
		{
			if (arr.Length <= 1) return arr; // Base case for recursion

			// Capture array length and middle index
			int len = arr.Length;
			int mid = len / 2;

			// Lengths for subarrays
			int leftArrLen = mid;
			int rightArrLen = len - mid;

			// Instantiate new subarrays
			int[] leftArr = new int[leftArrLen];
			int[] rightArr = new int[rightArrLen];

			// Copy contents in specified ranges from parent array to subarrays
			Array.Copy(arr, 0, leftArr, 0, leftArrLen);
			Array.Copy(arr, mid, rightArr, 0, rightArrLen);

			// Merge sorted subarrays
			return Merge(MergeSort(leftArr), MergeSort(rightArr), arr);
		}

		/// <summary>
		/// Takes in two subarrays and compares and sorts their values into a third array
		/// </summary>
		/// <param name="leftArr">left subarray</param>
		/// <param name="rightArr">right subarray</param>
		/// <param name="arr">sorted array of merged values</param>
		/// <returns>sorted array</returns>
		public static int[] Merge(int[] leftArr, int[] rightArr, int[] arr)
		{
			// Set starting indices for looping over subarrays and the merge array
			int leftIndex = 0;
			int rightIndex = 0;
			int currentIndex = 0;

			// Sort subarrays' values into merge array
			while (leftIndex < leftArr.Length && rightIndex < rightArr.Length)
			{
				if (leftArr[leftIndex] <= rightArr[rightIndex])
				{
					arr[currentIndex] = leftArr[leftIndex];
					leftIndex++;
				}
				else
				{
					arr[currentIndex] = rightArr[rightIndex];
					rightIndex++;
				}
				currentIndex++;
			}
			
			// Copy over remainder of longer subarray into merge array
			if (leftIndex == leftArr.Length)
			{
				Array.Copy(rightArr, rightIndex, arr, currentIndex, rightArr.Length - rightIndex);
			}
			else
			{
				Array.Copy(leftArr, leftIndex, arr, currentIndex, leftArr.Length - leftIndex);
			}

			return arr;
		}
	}
}
