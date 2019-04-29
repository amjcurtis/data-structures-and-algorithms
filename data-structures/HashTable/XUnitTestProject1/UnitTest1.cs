using Xunit;
using HashTable;

namespace XUnitTestProject1
{
	public class UnitTest1
	{

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
			bool valuePresent = ht.Contains("John");

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
	}
}
