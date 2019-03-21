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
                Console.WriteLine($"The element we searched for ({key}) is not present in the array we searched in.");
            }
            else
            {
                Console.WriteLine($"The index of the array’s element that is equal to our search key is {result}");
            }
            Console.WriteLine(" ");
            Console.WriteLine("Press Enter to exit the program.");
            Console.ReadLine();
        }

        public static int BinarySearch(int[] sortedArray, int key)
        {
            int min = 0;
            int max = sortedArray.Length;


            return key;
        }
    }
}
