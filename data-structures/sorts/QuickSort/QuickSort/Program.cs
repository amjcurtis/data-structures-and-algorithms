using System;

namespace QuickSort
{
	public class Program
	{
		static void Main(string[] args)
		{
			int[] myArray = new int[] { 6, 3, 2, 5, 9, 4, 7, 1, 8 };

			QuickSort(myArray, 0, myArray.Length - 1);

			PrintArray(myArray);

			Console.ReadLine();
		}

		/// <summary>
		/// Performs quick sort logic recursively on array
		/// </summary>
		/// <param name="arr">input array</param>
		/// <param name="left">leftmost element in array</param>
		/// <param name="right">rightmost element in array</param>
		public static void QuickSort(int[] arr, int left, int right)
		{
			if (left < right)
			{
				// Partition the algorithm
				int position = Partition(arr, left, right);

				// Sort left
				QuickSort(arr, left, position - 1);
				
				// Sort right
				QuickSort(arr, position + 1, right);
			}
		}

		/// <summary>
		/// Traverses array to find smaller element than current element and swaps them if smaller element found
		/// </summary>
		/// <param name="arr">input array</param>
		/// <param name="left">leftmost element in array</param>
		/// <param name="right">rightmost element in array</param>
		/// <returns></returns>
		public static int Partition(int[] arr, int left, int right)
		{
			// Set pivot
			int pivot = arr[right];

			// Get index of the lower value
			int low = left - 1;

			for (int i = left; i < right; i++)
			{
				if (arr[i] <= pivot)
				{
					low++;
					Swap(arr, i, low);
				}
			}

			Swap(arr, right, low + 1);
			return low + 1;
		}

		/// <summary>
		/// Swaps places of specified values in an array
		/// </summary>
		/// <param name="arr">input array</param>
		/// <param name="i">specified index of input array</param>
		/// <param name="low">pointer to a position at left of leftmost index</param>
		public static void Swap(int[] arr, int i, int low)
		{
			int temp = arr[i];
			arr[i] = arr[low];
			arr[low] = temp;
		}

		/// <summary>
		/// Prints values of an integer array
		/// </summary>
		/// <param name="arr">input array</param>
		public static void PrintArray(int[] arr)
		{
			// Capture length of input array
			int n = arr.Length;

			for (int i = 0; i < n; i++)
			{
				Console.Write(arr[i] + " ");
			}
			Console.WriteLine();
		}
	}
}
