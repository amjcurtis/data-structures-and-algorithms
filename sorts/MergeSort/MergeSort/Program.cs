using System;

namespace MergeSort
{
	public class Program
	{
		static void Main(string[] args)
		{
			int[] arrayToSort = new int[] { 4,7,2,3,6,8,1,9,5 };
			MergeSort(arrayToSort);

			for (int i = 0; i < arrayToSort.Length; i++)
			{
				Console.Write("[{0}] ", arrayToSort[i]);
			}

			Console.ReadLine();
		}

		public static void MergeSort(int[] arr)
		{
			int arrLength = arr.Length;

			// Only runs if input array has more than one element, since array of only one element is considered already sorted
			if (arrLength > 1)
			{
				// Get middle index of input array
				int mid = Convert.ToInt32(Math.Floor(Convert.ToDouble(arrLength / 2)));

				// Set lengths of left and right subarrays
				int leftSubArrayLength = mid;
				int rightSubArrayLength = arrLength - mid;

				// Declare new arrays with lengths of left and right subarrays
				int[] leftSubArray = new int[leftSubArrayLength];
				int[] rightSubArray = new int[rightSubArrayLength];

				// Copy the two halves of input array into subarrays
				Array.Copy(arr, 0, leftSubArray, 0, leftSubArrayLength);
				Array.Copy(arr, 0, rightSubArray, 0, rightSubArrayLength);

				// Call MergeSort recursively on subarrays
				MergeSort(leftSubArray);
				MergeSort(rightSubArray);

				// Call Merge helper method on subarrays
				Merge(leftSubArray, rightSubArray, arr);
			}
		}

		public static int[] Merge(int[] leftSubArray, int[] rightSubArray, int[] arr)
		{
			int i = 0;
			int j = 0;
			int k = 0;

			while (i < leftSubArray.Length && j < rightSubArray.Length)
			{
				if (leftSubArray[i] <= rightSubArray[j])
				{
					arr[k] = leftSubArray[i];
					i++;
				}
				else
				{
					arr[k] = rightSubArray[j];
					j++;
				}
				k++;
			}

			if (i == leftSubArray.Length)
			{
				Array.Copy(rightSubArray, k, arr, i, rightSubArray.Length - k);
			}
			else
			{
				Array.Copy(leftSubArray, k, arr, j, leftSubArray.Length - k);
			}

			return arr;
		}
	}
}
