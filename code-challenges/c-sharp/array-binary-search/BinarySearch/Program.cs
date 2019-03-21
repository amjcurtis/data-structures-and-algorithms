using System;

namespace BinarySearch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the binary search challenge!");
            Console.WriteLine(" ");

            int[] inputArray = { 4, 8, 15, 16, 19, 20, 23, 26, 29, 34, 39, 42 };
            Console.WriteLine("The array we will search to find our key value is {0}", string.Join(", ", inputArray));

            int key = 15;
            Console.WriteLine($"The key value we will search for is {key}.");

            // Save result of BinarySearch algorithm method
            int result = BinarySearch(inputArray, key);

            if (result == -1)
            {
                Console.WriteLine($"The index returned by our algorithm is [{result}]");
                Console.WriteLine($"This means the element we searched for ({key}) is not present in the array we searched in.");
            }
            else
            {
                Console.WriteLine($"The index of the array element that is equal to our search key is [{result}]");
            }
            Console.WriteLine(" ");
            Console.WriteLine("Press Enter to exit the program.");
            Console.ReadLine();
        }

        public static int BinarySearch(int[] array, int key)
        {
            int min = 0;
            int max = array.Length -1;
            while (min <= max)
            {
                int mid = Convert.ToInt32(Math.Floor(Convert.ToDouble((min + max) / 2)));
                if (array[mid] < key)
                {
                    min = mid + 1;
                }
                else if (array[mid] > key)
                {
                    max = mid - 1;
                }
                else
                {
                    return mid;
                }
            }

            return -1;
        }
    }
}
