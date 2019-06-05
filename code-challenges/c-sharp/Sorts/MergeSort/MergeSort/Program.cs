using System;
using System.Collections.Generic;

namespace MergeSort
{
	public class Program
	{
		static void Main(string[] args)
		{
			int[] nums = new int[] { 4, 7, 3, 6, 2, 8, 1, 9, 5 };

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

		public static int[] MergeSort(int[] arr)
		{
			if (arr.Length <= 1) return arr;

			int len = arr.Length;
			int mid = len / 2;

			int leftArrLen = mid;
			int rightArrLen = len - mid;

			int[] leftArr = new int[leftArrLen];
			int[] rightArr = new int[rightArrLen];

			Array.Copy(arr, 0, leftArr, 0, leftArrLen);
			Array.Copy(arr, mid, rightArr, 0, rightArrLen);

			return Merge(MergeSort(leftArr), MergeSort(rightArr), arr);
		}

		public static int[] Merge(int[] leftArr, int[] rightArr, int[] arr)
		{
			int leftIndex = 0;
			int rightIndex = 0;
			int currentIndex = 0;

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
