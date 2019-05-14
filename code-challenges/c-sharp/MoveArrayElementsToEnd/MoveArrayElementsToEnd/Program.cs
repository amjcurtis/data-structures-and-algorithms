using System;

namespace MoveArrayElementsToEnd
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] array = new int[] { 0, 1, 0, 7, 5, 7, 0, 12, 0 };

			MoveNumToEnd(array, 0);

			// Print mutated array
			for (int i = 0; i < array.Length; i++)
			{
				Console.Write($"{array[i]} ");
			}
			Console.WriteLine();
		}

		/// <summary>
		/// Takes in integer array and mutates it in place, moving all instances of specified number (if any) to end of array
		/// </summary>
		/// <param name="arr">array to mutate</param>
		/// <param name="num">number to move</param>
		public static void MoveNumToEnd(int[] arr, int num)
		{
			// Iterate over array backwards
			for (int i = arr.Length - 1; i >= 0; i--)
				//for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] == num)
				{
					int temp = arr[i];
					for (int j = i; j < arr.Length; j++)
					{
						if (j != arr.Length - 1) // If stmt to prevent IndexOutOfRange exception
						{
							arr[j] = arr[j + 1];
						}
					}
					arr[arr.Length - 1] = temp;
				}
			}
		}
	}
}
