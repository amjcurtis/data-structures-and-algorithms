using System;

namespace BubbleSort
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] nums = new int[] { 4, 3, 1, 9, 7, 5, 8, 6, 2 };

			// Print array before sorting
			for (int i = 0; i < nums.Length; i++)
			{
				Console.Write("{0} ", nums[i]);
			}
			Console.WriteLine();

			// Sort array
			BubbleSort(nums);

			// Print array after sorting
			for (int i = 0; i < nums.Length; i++)
			{
				Console.Write("{0} ", nums[i]);
			}
			Console.WriteLine();
		}

		public static void BubbleSort(int[] arr)
		{
			int temp;

			for (int i = 0; i < arr.Length - 1; i++)
			{
				for (int j = 1; j < arr.Length; j++)
				{
					if (arr[j] < arr[j - 1])
					{
						temp = arr[j];
						arr[j] = arr[j - 1];
						arr[j - 1] = temp;
					}
				}
			}
		}
	}
}
