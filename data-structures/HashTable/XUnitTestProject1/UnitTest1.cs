using Xunit;
using HashTable;

namespace XUnitTestProject1
{
	public class UnitTest1
	{

		/////////////////////////////////////
		// Tests for methods on Hashtable class
		/////////////////////////////////////

		/// <summary>
		/// Tests whether can add new key:value pair to hash table
		/// </summary>
		[Fact]
		public void CanAddNodeToHashTable()
		{
			// Arrange
			Hashtable ht = new Hashtable(1024);

			// Act
			ht.Add("John", "Instructor");
			bool valuePresent = ht.ContainsKey("John");

			// Assert
			Assert.True(valuePresent);
		}

		/// <summary>
		/// Tests whether can get value of key:value pair present in hash table
		/// </summary>
		[Fact]
		public void CanGetValuePresentInHashTable()
		{
			// Arrange
			Hashtable ht = new Hashtable(1024);
			ht.Add("John", "Instructor");

			// Act
			Node node = ht.Get("John");

			// Assert
			Assert.Equal("Instructor", node.Value);
		}

		/// <summary>
		/// Tests whether can return null when searched key not present in table
		/// </summary>
		[Fact]
		public void CanReturnNullWhenSearchedKeyNotPresentInTable()
		{
			// Arrange
			Hashtable ht = new Hashtable(1024);

			// Act
			Node node = ht.Get("John");

			// Assert
			Assert.Null(node);
		}

		/// <summary>
		/// Tests whether can add multiple key:value pairs with same hash value to table
		/// </summary>
		[Fact]
		public void CanHandleCollision()
		{
			// Arrange
			Hashtable ht = new Hashtable(16);

			// Act
			ht.Add("John", "Instructor");
			ht.Add("Joim", "Friend");

			int nodeCount = 0;
			for (int i = 0; i < ht.Map.Length; i++)
			{
				if (ht.Map[i] != null)
				{
					foreach (var item in ht.Map[i])
					{
						if (item.Key == "John")
						{
							nodeCount = ht.Map[i].Count;
						}

					}
				}
			}

			// Assert
			Assert.Equal(2, nodeCount);
		}

		/// <summary>
		/// Tests whether can get value of a collided node in table
		/// </summary>
		[Fact]
		public void CanGetValueOfCollidedNode()
		{
			// Arrange
			Hashtable ht = new Hashtable(16);

			// Act
			ht.Add("John", "Instructor");
			ht.Add("Joim", "Friend");

			Node node = ht.Get("Joim");

			// Assert
			Assert.Equal("Friend", node.Value);
		}

		/// <summary>
		/// Tests whether can hash key to an in-range value
		/// </summary>
		[Fact]
		public void CanHashKeyToAnInRangeValue()
		{
			// Arrange
			Hashtable ht = new Hashtable(16);

			// Act
			int hash = ht.Hash("Pioneer Square");

			// Assert
			Assert.True(hash <= 16);
		}


		/////////////////////////////////////
		// Tests for RepeatedWord() static method
		/////////////////////////////////////

		/// <summary>
		/// Tests whether can successfully return first repeated word (happy path)
		/// </summary>
		[Fact]
		public void CanReturnFirstRepeatedWord()
		{
			// Arrange
			string sentence = "The quick brown fox jumped over the lazy dog.";

			// Act
			string firstRepeatedWordInSentence = Program.RepeatedWord(sentence);

			// Assert
			Assert.Equal("the", firstRepeatedWordInSentence);
		}

		/// <summary>
		/// Tests whether can return null if no repeated word exists in input string
		/// </summary>
		[Fact]
		public void CanReturnNullIfNoRepeatWordFound()
		{
			// Arrange
			string sentence = "The quick brown fox jumped over a lazy dog.";

			// Act
			string firstRepeatedWordInSentence = Program.RepeatedWord(sentence);

			// Assert
			Assert.Null(firstRepeatedWordInSentence);
		}

		/// <summary>
		/// Tests whether can handle empty string argument by returning null
		/// </summary>
		[Fact]
		public void CanHandleEmptyStringAsInput()
		{
			// Arrange
			string sentence = "";

			// Act
			string firstRepeatedWordInSentence = Program.RepeatedWord(sentence);

			// Assert
			Assert.Null(firstRepeatedWordInSentence);
		}

	}
}
