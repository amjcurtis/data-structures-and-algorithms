using System;
using System.Diagnostics;

namespace BubbleSort
{
	public class Program
	{
		static void Main(string[] args)
		{
			//int[] nums = new int[] { 4, 3, 1, 9, 7, 5, 8, 6, 2 };

			// Generate array of random numbers
			int size = 2500;
			int[] nums = new int[size];
			Random random = new Random();
			int randomRange = size * 4;
			for (int i = 0; i < size; i++)
			{
				int rand = random.Next(1, randomRange);
				nums[i] = rand;
			}

			// Print array before sorting
			for (int i = 0; i < nums.Length; i++)
			{
				Console.Write("{0} ", nums[i]);
			}
			Console.WriteLine();

			// Sort array
			Stopwatch stopwatch = Stopwatch.StartNew();
			BubbleSort(nums);
			stopwatch.Stop();

			// Print array after sorting
			for (int i = 0; i < nums.Length; i++)
			{
				Console.Write("{0} ", nums[i]);
			}
			Console.WriteLine();
			Console.WriteLine(stopwatch.Elapsed);
		}

		/// <summary>
		/// Sorts array in place using bubble sort with O(n^2) time complexity
		/// </summary>
		/// <param name="arr">array to sort</param>
		public static void BubbleSort(int[] arr)
		{
			int temp;

			for (int i = 0; i < arr.Length; i++)
			{
				for (int j = 0; j < arr.Length - i - 1; j++)
				{
					if (arr[j] > arr[j + 1])
					{
						temp = arr[j];
						arr[j] = arr[j + 1];
						arr[j + 1] = temp;
					}
				}
			}
		}
	}
}
