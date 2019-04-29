using System;

namespace HashTable
{
	class Program
	{
		static void Main(string[] args)
		{
			// Initialize hash table of specified size
			HashTable ht = new HashTable(1024);

			// Populate hash table
			ht.Add("John", "Husband");
			ht.Add("Cathy", "Boss");
			ht.Add("Amanda", "Instructor");
			ht.Add("Allie", "Classmate");
			ht.Add("Zach", "Friend");
			ht.Add("Rosie", "Cat");
			ht.Add("Justin", "Parrot");
			ht.Add("Demi", "Dog");
			ht.Add("Ovi", "Student");
			ht.Add("Ben", "Student");
			ht.Add("Khalil", "Student");
			ht.Add("Jason", "Student");

			// Print contents of hash table
			ht.Print();

			// Demo Contains() method
			bool key1 = ht.Contains("Demi");
			Console.WriteLine(key1);
			bool key2 = ht.Contains("T-Rex");
			Console.WriteLine(key2);

			// Demo Get() method
			Node node1 = ht.Get("Amanda");
			Console.WriteLine($"{node1.Key}:{node1.Value}");

			Console.ReadLine();
		}
	}
}
