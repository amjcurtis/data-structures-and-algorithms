using System;

namespace InsertionSort
{
	public class Program
	{
		static void Main(string[] args)
		{
			int[] array = new int[] { 4, 3, 1, 8, 5, 7, 2 };

			int[] sortedArray = InsertionSort(array);

			for (int i = 0; i < sortedArray.Length; i++)
			{
				Console.Write("{0} ", sortedArray[i]);
			}

			Console.ReadLine();
		}

		/// <summary>
		/// Sorts an array of integers using insertion sort
		/// </summary>
		/// <param name="inputArray">array of integers</param>
		/// <returns>sorted integer array</returns>
		public static int[] InsertionSort(int[] inputArray)
		{
			if (inputArray.Length == 0)
			{
				return inputArray;
			}

			for (int i = 1; i < inputArray.Length; i++)
			{
				int j = i - 1;
				int temp = inputArray[i];

				while (j >= 0 && temp < inputArray[j])
				{
					inputArray[j + 1] = inputArray[j];
					j = j - 1;
				}

				inputArray[j + 1] = temp;
			}

			return inputArray;
		}
	}
}
