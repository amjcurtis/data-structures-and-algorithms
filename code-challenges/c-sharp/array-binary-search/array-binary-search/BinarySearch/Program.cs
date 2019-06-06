using System;

namespace BinarySearch
{
    public class Program
    {
        /// <summary>
        /// Contains console app UI and exception handling
        /// </summary>
        /// <param name="args">string[] args</param>
        public static void Main(string[] args)
        {
			// Generate array of random numbers
			int size = 25; 
			int[] nums = new int[size];
			Random random = new Random();
			int randomRange = size * 4;
			for (int i = 0; i < size; i++)
			{
				int rand = random.Next(1, randomRange);
				nums[i] = rand;
			}

			// Sort array (necessary for binary search to work)
			Array.Sort(nums);

			try
            {
                Console.WriteLine($"Enter a number you'd like to search for in an array of {randomRange} numbers.");
                string chosenNumberAsString = Console.ReadLine();

                int chosenNumberAsInt = Convert.ToInt32(chosenNumberAsString);

                // Set key value to search for
                int key = chosenNumberAsInt;
                Console.WriteLine($"Ok, the key value we will search for is {key}.");
				
                // Capture result of BinarySearch algorithm method
                int? result = BinarySearch(nums, key);

                if (result == null)
                {
                    Console.WriteLine($"The element we searched for ({key}) is not present in the array we searched in.");
                }
                else
                {
                    Console.WriteLine($"The index of the array element that is equal to our search key is [{result}]");
                }

                Console.WriteLine("Here's the array we searched for our number in:\n" +
                    "[{0}]", string.Join(", ", nums));

                Console.WriteLine("\nThanks for trying out our algorithm!");
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("\nPress Enter to exit the program.\n");
            }
        }

        /// <summary>
        /// Binary search algorithm
        /// </summary>
        /// <param name="array">array to search in</param>
        /// <param name="key">value to search array for</param>
        /// <returns>integer searched for or null if value not found</returns>
        public static int? BinarySearch(int[] array, int key)
        {
            int min = 0;
            int max = array.Length -1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
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
            return null;
        }
    }
}
