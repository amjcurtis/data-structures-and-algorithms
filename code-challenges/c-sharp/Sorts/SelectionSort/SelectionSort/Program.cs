﻿using System;

namespace SelectionSort
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] nums = new int[] { 7, 4, 3, 9, 8, 6, 2, 10, 5 };

			// Print array before sorting
			foreach (int num in nums)
			{
				Console.Write("{0} ", num);
			}
			Console.WriteLine();

			// Sort array
			SelectionSort(nums);

			// Print array after sorting
			foreach (int num in nums)
			{
				Console.Write("{0} ", num);
			}
			Console.WriteLine();
		}

		public static void SelectionSort(int[] arr)
		{
			int min, temp;

			for (int i = 0; i < arr.Length - 1; i++)
			{
				min = i; // Points to index of current lowest num
				for (int j = i + 1; j < arr.Length; j++)
				{
					if (arr[j] < arr[min])
					{
						min = j;
					}
				}
				temp = arr[i];
				arr[i] = arr[min];
				arr[min] = temp;
			}
		}
	}
}