using System;

namespace HashTable
{
	class Program
	{
		static void Main(string[] args)
		{
			// Initialize hash table of specified size
			Hashtable ht = new Hashtable(1024);

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


			// Demo RepeatedWord() method
			string sentence1 = "Once upon a time, there was a brave princess who...";
			string[] wordsArray = sentence1.Split(new char[] { ' ', ',', '.', ':', ';', '\t' }, StringSplitOptions.RemoveEmptyEntries);
			Console.WriteLine("[{0}]", string.Join(" ", wordsArray));

			string firstRepeatedWordInSentence1 = RepeatedWord(sentence1);
			Console.WriteLine($"First repeated word in sentence1: {firstRepeatedWordInSentence1}");

			string sentence2 = "It was the best of times, it was the worst of times, it was the age of wisdom, it was the age of foolishness, it was the epoch of belief, it was the epoch of incredulity, it was the season of Light, it was the season of Darkness, it was the spring of hope, it was the winter of despair, we had everything before us, we had nothing before us, we were all going direct to Heaven, we were all going direct the other way – in short, the period was so far like the present period, that some of its noisiest authorities insisted on its being received, for good or for evil, in the superlative degree of comparison only...";
			string firstRepeatedWordInSentence2 = RepeatedWord(sentence2);
			Console.WriteLine($"First repeated word in sentence2: {firstRepeatedWordInSentence2}");


			Console.ReadLine();
		}


		public static string RepeatedWord(string sentence)
		{
			char[] separator = new char[] { ' ', ',', '.', ':', ';', '\t' };
			string[] wordsArray = sentence.Split(separator, StringSplitOptions.RemoveEmptyEntries);

			Hashtable ht = new Hashtable(1024);
			string currentWord;

			for (int i = 0; i < wordsArray.Length; i++)
			{
				// Change each word to lower case before adding to ht
				currentWord = wordsArray[i].ToLower();

				if (!ht.Contains(currentWord))
				//if (ht.Get(currentWord) == null) // Alternate conditional test
				{
					// Current word will be both key and value in the key:value pair added to HT
					ht.Add(currentWord, currentWord);
				}
				else
				{
					// Returning wordsArray[i] instead of currentWord preserves original capitalization
					return wordsArray[i]; 
				}
			}
			return null;
		}
	}
}
