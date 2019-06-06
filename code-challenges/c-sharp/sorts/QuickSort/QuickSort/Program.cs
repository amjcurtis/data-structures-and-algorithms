using System;

namespace QuickSort
{
	public class Program
	{
		static void Main(string[] args)
		{
			// Generate array of random numbers
			int[] nums = new int[25];
			Random random = new Random();
			for (int i = 0; i < 25; i++)
			{
				int rand = random.Next(1, 26);
				nums[i] = rand;
			}

			// Print array before sorting
			Console.WriteLine("Array before sorting:");
			PrintArray(nums);

			// Sort array
			QuickSort(nums);

			// Print array after sorting
			Console.WriteLine("\nArray after sorting:");
			PrintArray(nums);
			Console.WriteLine();
		}

		/// <summary>
		/// Override method for QuickSort
		/// </summary>
		/// <param name="arr">array to sort</param>
		public static void QuickSort(int[] arr)
		{
			QuickSort(arr, 0, arr.Length - 1);
		}

		/// <summary>
		/// Sorts array in place using quick sort with O(n log n) runtime in best and average cases, O(n^2) in worst case 
		/// </summary>
		/// <param name="arr">array to sort</param>
		/// <param name="left">leftmost index of array</param>
		/// <param name="right">rightmost index of array</param>
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
		/// <param name="left">leftmost index of array</param>
		/// <param name="right">rightmost index of array</param>
		/// <returns>new lowest index</returns>
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
		/// Prints array values
		/// </summary>
		/// <param name="arr">array to print</param>
		public static void PrintArray(int[] arr)
		{
			foreach (int num in arr)
			{
				Console.Write("{0} ", num);
			}
			Console.WriteLine();
		}
	}
}
