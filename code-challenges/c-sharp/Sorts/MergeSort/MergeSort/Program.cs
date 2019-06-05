using System;

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
			MergeSorter1(nums);

			// Print array after sorting
			for (int i = 0; i < nums.Length; i++)
			{
				Console.Write("{0} ", nums[i]);
			}
			Console.WriteLine();
		}

		// This algo for merge sort is taken straight from GLM's book to see if at least this one works
		//public static void MergeSorter2(int[] array)
		//{
		//	int[] helper = new int[array.Length];
		//	MergeSort2(array, helper, 0, array.Length - 1);
		//}

		//public static void MergeSort2(int[] array, int[] helper, int low, int high)
		//{
		//	if (low < high)
		//	{
		//		int middle = (low + high) / 2;
		//		MergeSort2(array, helper, low, middle);
		//		MergeSort2(array, helper, middle + 1, high);
		//		Merge2(array, helper, low, middle, high);
		//	}
		//}

		//public static void Merge2(int[] array, int[] helper, int low, int middle, int high)
		//{
		//	for (int i = low; i < high; i++)
		//	{
		//		helper[i] = array[i];
		//	}

		//	int helperLeft = low;
		//	int helperRight = middle + 1;
		//	int current = low;

		//	while (helperLeft <= middle && helperRight <= high)
		//	{
		//		if (helper[helperLeft] <= helper[helperRight])
		//		{
		//			array[current] = helper[helperLeft];
		//			helperLeft++;
		//		}
		//		else
		//		{
		//			array[current] = helper[helperRight];
		//			helperRight++;
		//		}
		//		current++;
		//	}

		//	int remaining = middle - helperLeft;
		//	for (int i = 0; i <= remaining; i++)
		//	{
		//		array[current + i] = helper[helperLeft + i];
		//	}
		//}

		// Combined approach that borrows from both GLM's book and various online resources
		public static void MergeSorter1(int[] arr)
		{
			int[] tempArr = new int[arr.Length];
			MergeSort1(arr, tempArr, 0, arr.Length - 1);
		}

		public static void MergeSort1(int[] arr, int[] tempArr, int leftStart, int rightEnd)
		{
			if (leftStart < rightEnd)
			{
				int mid = (leftStart + rightEnd) / 2;

				MergeSort1(arr, tempArr, leftStart, mid);
				MergeSort1(arr, tempArr, mid + 1, rightEnd);
				Merge1(arr, tempArr, leftStart, rightEnd);
			}
		}

		public static void Merge1(int[] arr, int[] tempArr, int leftStart, int rightEnd)
		{
			int leftEnd = (leftStart + rightEnd) / 2;
			int rightStart = leftEnd + 1;
			int len = rightEnd - leftStart + 1;

			int leftIndex = leftStart;
			int rightIndex = rightStart;
			int currentIndex = leftStart;

			while (leftIndex <= leftEnd && rightIndex <= rightEnd)
			{
				if (arr[leftIndex] <= arr[rightIndex])
				{
					arr[leftIndex] = tempArr[currentIndex];
					leftIndex++;
				}
				else
				{
					arr[rightIndex] = tempArr[currentIndex];
					rightIndex++;
				}
				currentIndex++;
			}

			// Copy over rest of left subarray into original array
			// Attempt #1
			int remaining = leftEnd - leftIndex;
			for (int i = 0; i < remaining; i++)
			{
				arr[currentIndex + i] = tempArr[leftIndex];
			}

			// Attempt #2
			//Array.Copy(arr, leftIndex, tempArr, currentIndex, leftEnd - leftIndex + 1);
			//Array.Copy(arr, rightIndex, tempArr, currentIndex, rightEnd - rightIndex + 1);
			//Array.Copy(tempArr, leftStart, arr, leftStart, len);

			//// Attempt #3
			//if (leftIndex == tempArr.Length)
			//{
			//	Array.Copy(arr, rightIndex, tempArr, currentIndex, rightIndex - rightIndex + 1);
			//}
			//else
			//{
			//	Array.Copy(arr, leftIndex, tempArr, currentIndex, leftEnd - leftIndex + 1);
			//}
		}
	}
}
