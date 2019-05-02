using Xunit;
using System.Collections.Generic;
using LeftJoinHashTables;
using HashTable;
using Program = LeftJoinHashTables.Program;

namespace XUnitTest_LeftJoin
{
	public class UnitTests_LeftJoin
	{

		/// <summary>
		/// Tests happy path, i.e. whether LeftJoin method can return left-joined list of arrays
		/// </summary>
		[Fact]
		public void CanReturnLeftJoinedRows()
		{			
			// ARRANGE
			
			// Instantiate first hash table
			Hashtable ht1 = new Hashtable(1024);

			// Add key:value pairs to first HT
			ht1.Add("fond", "enamored");
			ht1.Add("wrath", "anger");
			ht1.Add("diligent", "employed");
			ht1.Add("outfit", "garb");
			ht1.Add("guide", "usher");

			// Instantiate second hash table
			Hashtable ht2 = new Hashtable(1024);

			// Add other key:value pairs to second HT
			ht2.Add("fond", "averse");
			ht2.Add("wrath", "delight");
			ht2.Add("diligent", "idle");
			ht2.Add("guide", "follow");
			ht2.Add("flow", "jam");

			// ACT

			// Capture list of arrays returned by LeftJoin method
			List<string[]> leftJoin = Program.LeftJoin(ht1, ht2);

			string[] array = leftJoin[0];
			string rightTableValue = (string) array.GetValue(2);
			
			// ASSERT
			Assert.Contains("idle", rightTableValue);
		}

		/// <summary>
		/// Tests whether LeftJoin can return NULL string if right table does contain current key in left table
		/// </summary>
		[Fact]
		public void CanReturnNullStringIfRightTableNotContainsKey()
		{
			// ARRANGE

			// Instantiate first hash table
			Hashtable ht1 = new Hashtable(1024);

			// Add key:value pairs to first HT
			ht1.Add("fond", "enamored");
			ht1.Add("wrath", "anger");
			ht1.Add("diligent", "employed");
			ht1.Add("outfit", "garb");
			ht1.Add("guide", "usher");

			// Instantiate second hash table
			Hashtable ht2 = new Hashtable(1024);

			// Add other key:value pairs to second HT
			ht2.Add("fond", "averse");
			ht2.Add("wrath", "delight");
			ht2.Add("diligent", "idle");
			ht2.Add("guide", "follow");
			ht2.Add("flow", "jam");

			// ACT

			// Capture list of arrays returned by LeftJoin method
			List<string[]> leftJoin = Program.LeftJoin(ht1, ht2);

			string[] array = leftJoin[1];
			string rightTableValue = (string)array.GetValue(2);

			// ASSERT
			Assert.Contains("NULL", rightTableValue);
		}

		[Fact]
		public void CanReturnEmptyListIfBothTablesEmpty()
		{
			// ARRANGE
			Hashtable ht1 = new Hashtable(1024);
			Hashtable ht2 = new Hashtable(1024);

			// ACT
			List<string[]> leftJoin = Program.LeftJoin(ht1, ht2);

			// ASSERT
			Assert.Empty(leftJoin);
		}
	}
}
