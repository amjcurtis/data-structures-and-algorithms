using System;
using Xunit;
using HashTable;
using System.Collections;

namespace XUnitTest_HashTable
{
	public class UnitTests_HashTable
	{
		//TODO Adding a key/value to your hashtable results in the value being in the data structure
		[Fact]
		public void CanAddNodeToHashTable()
		{
			HashTable ht = new HashTable(1024);

		}


		//TODO Retrieving based on a key returns the value stored
		//TODO DSuccessfully returns null for a key that does not exist in the hashtable
		//TODO Successfully handle a collision within the hashtable
		//TODO Successfully retrieve a value from a bucket within the hashtable that has a collision
		//TODO Successfully hash a key to an in-range value
	}
}
