using System;

namespace InsertionSort
{
	public class Program
	{
		static void Main(string[] args)
		{
			int[] array = new int[] { 4, 3, 1, 9, 7, 5, 8, 6, 2 };

			// Print array before sorting
			for (int i = 0; i < array.Length; i++)
			{
				Console.Write("{0} ", array[i]);
			}
			Console.WriteLine();

			// Sort array
			InsertionSort(array);

			// Print array after sorting
			for (int i = 0; i < array.Length; i++)
			{
				Console.Write("{0} ", array[i]);
			}
			Console.WriteLine();
		}

		/// <summary>
		/// Sorts an array of integers using insertion sort
		/// </summary>
		/// <param name="arr">array of integers</param>
		/// <returns>sorted integer array</returns>
		public static void InsertionSort(int[] arr)
		{
			if (arr.Length == 0)
			{
				return;
			}

			for (int i = 1; i < arr.Length; i++)
			{
				int j = i - 1;
				int temp = arr[i];

				while (j >= 0 && temp < arr[j])
				{
					arr[j + 1] = arr[j];
					j = j - 1;
				}

				arr[j + 1] = temp;
			}
		}
	}
}
