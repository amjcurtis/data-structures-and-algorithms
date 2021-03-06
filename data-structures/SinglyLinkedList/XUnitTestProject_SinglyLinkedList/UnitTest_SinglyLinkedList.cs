using ConsoleApp_LinkedList.Classes;
using Xunit;

namespace XUnitTestProject_SinglyLinkedList
{
	public class UnitTest_SinglyLinkedList
	{
		/// <summary>
		/// Tests successful instantiation of empty linked list
		/// </summary>
		[Fact]
		public void CanInstantiateEmptyLinkedList()
		{
			// Act
			LList myLinkedList = new LList();

			// Assert
			Assert.NotNull(myLinkedList);
		}

		/// <summary>
		/// Tests successful insertion of new node at beginning of linked list
		/// </summary>
		[Fact]
		public void CanInsertNodeIntoLinkedList()
		{
			// Arrange
			LList newList = new LList();

			// Act
			newList.Insert(12);

			// Assert
			Assert.Equal(12, newList.Head.Value);
		}

		/// <summary>
		/// Tests whether Head node is sole node in list and whether its value is expected value
		/// </summary>
		[Fact]
		public void DoesHeadPointToFirstNode()
		{
			// Arrange
			LList newList = new LList();

			// Act
			// Insert single node into list
			newList.Insert(114);

			// Assert
			// Check whether Head node is the only node in list
			Assert.Null(newList.Head.Next);
			// Check whether value of the list's single node equals value of node's Head
			Assert.Equal(114, newList.Head.Value);
		}

		/// <summary>
		/// Tests presence of multiple nodes in list by verifying Head node's Next is not null
		/// </summary>
		[Fact]
		public void CanInsertMultipleNodesIntoList()
		{
			// Arrange
			LList newList = new LList();

			// Act
			newList.Insert(7);
			newList.Insert(12);

			// Assert
			Assert.NotNull(newList.Head.Next);
		}

		/// <summary>
		/// Tests if returns true when finding a value present in list
		/// </summary>
		[Fact]
		public void CanVerifyValueExistsInList()
		{
			// Arrange
			LList newList = new LList();
			newList.Insert(5);
			newList.Insert(16);

			// Act
			bool listIncludesVal = newList.Includes(16);

			// Assert
			Assert.True(listIncludesVal);
		}

		/// <summary>
		/// Tests if returns false when checking for a value not present in list
		/// </summary>
		[Fact]
		public void CanVerifyValueNotExistsInList()
		{
			// Arrange
			LList newList = new LList();
			newList.Insert(5);
			newList.Insert(16);

			// Act
			bool listIncludesVal = newList.Includes(3);

			// Assert
			Assert.False(listIncludesVal);
		}

		/// <summary>
		/// Tests if Print() method returns array of all values in list
		/// </summary>
		/// <param name="index">index to check for value at</param>
		/// <param name="value">value to check for</param>
		[Theory]
		[InlineData(0, 3)]
		[InlineData(1, 2)]
		[InlineData(2, 1)]
		public void CanReturnArrayOfAllValuesInList(int index, int value)
		{
			// Arrange
			LList newList = new LList();
			for (int i = 0; i < 3; i++)
			{
				newList.Insert(i + 1);
			}

			// Act
			int[] printedVals = newList.Print();

			// Assert
			Assert.Equal(printedVals[index], value);
		}

		/// <summary>
		/// Tests whether can append new node to end of list
		/// </summary>
		[Fact]
		public void CanAddNodeToEndOfList()
		{
			// Arrange
			LList newList = new LList();
			for (int i = 0; i < 3; i++)
			{
				newList.Insert(i + 1);
			}

			// Act
			newList.Append(56);
			int[] printedVals = newList.Print();

			// Assert
			Assert.Equal(56, printedVals[printedVals.Length - 1]);
		}

		/// <summary>
		/// Tests whether can append multiple new nodes to end of list
		/// </summary>
		[Theory]
		[InlineData(3, 49)]
		[InlineData(4, 49)]
		public void CanAddMultipleNodesToEndOfList(int index, int value)
		{
			// Arrange
			LList newList = new LList();
			for (int i = 0; i < 3; i++)
			{
				newList.Insert(i + 1);
			}

			// Act
			newList.Append(value);
			newList.Append(value);
			int[] printedVals = newList.Print();

			// Assert
			Assert.Equal(printedVals[index], value);
		}

		/// <summary>
		/// Tests whether can insert new node before middle node in list
		/// </summary>
		[Fact]
		public void CanInsertNodeBeforeMiddleNodeInList()
		{
			// Arrange
			LList newList = new LList();
			for (int i = 0; i < 3; i++)
			{
				newList.Insert(i + 1);
			}

			// Act
			newList.InsertBefore(2, 81);
			int[] printedVals = newList.Print();

			// Assert
			Assert.Equal(81, printedVals[1]);
		}

		/// <summary>
		/// Tests whether can use InsertBefore() to insert new node before first node in list
		/// </summary>
		[Fact]
		public void CanInsertNodeBeforeFirstNodeInList()
		{
			// Arrange
			LList newList = new LList();
			for (int i = 0; i < 3; i++)
			{
				newList.Insert(i + 1);
			}

			// Act
			newList.InsertBefore(3, 85);

			// Assert
			Assert.Equal(85, newList.Head.Value);
		}

		/// <summary>
		/// Tests whether can insert new node after middle node in list
		/// </summary>
		[Fact]
		public void CanInsertNodeAfterMiddleNodeInList()
		{
			// Arrange
			LList newList = new LList();
			for (int i = 0; i < 3; i++)
			{
				newList.Insert(i + 1);
			}

			// Act
			newList.InsertAfter(2, 81);
			int[] printedVals = newList.Print();

			// Assert
			Assert.Equal(81, printedVals[2]);
		}

		/// <summary>
		/// Tests whether can use InsertAfter() to insert new node after last node in list
		/// </summary>
		[Fact]
		public void CanInsertNodeAfterLastNodeInList()
		{
			// Arrange
			LList newList = new LList();
			for (int i = 0; i < 3; i++)
			{
				newList.Insert(i + 1);
			}

			// Act
			newList.InsertAfter(1, 85);
			int[] printedVals = newList.Print();

			// Assert
			Assert.Equal(85, printedVals[printedVals.Length - 1]);
		}

		/// <summary>
		/// Returns null node if k greater than length of list
		/// </summary>
		[Fact]
		public void CanHandleKGreaterThanLengthOfList()
		{
			// Arrange
			LList newList = new LList();
			for (int i = 0; i < 4; i++)
			{
				newList.Insert(i + 1);
			}

			// Act
			Node result = newList.GetKthNodeFromEnd(7);

			// Assert
			Assert.Null(result);
		}

		/// <summary>
		/// Tests whether can get value of node when k equals length of list
		/// </summary>
		[Fact]
		public void CanHandleKEqualToLengthOfList()
		{
			// Arrange
			LList newList = new LList();
			for (int i = 0; i < 4; i++)
			{
				newList.Insert(i + 1);
			}

			// Act
			Node result = newList.GetKthNodeFromEnd(4);

			// Assert
			Assert.Equal(4, result.Value);
		}

		/// <summary>
		/// Tests whether can return null node if k is negative value
		/// </summary>
		[Fact]
		public void CanHandleNegativeKValue()
		{
			// Arrange
			LList newList = new LList();
			for (int i = 0; i < 4; i++)
			{
				newList.Insert(i + 1);
			}

			// Act
			Node result = newList.GetKthNodeFromEnd(-2);

			// Assert
			Assert.Null(result);
		}

		/// <summary>
		/// Test whether can return value of kth node in list with only one node
		/// </summary>
		[Fact]
		public void CanHandleListWithOneNode()
		{
			// Arrange
			LList newList = new LList();
			newList.Insert(4);

			// Act
			Node result = newList.GetKthNodeFromEnd(1);

			// Assert
			Assert.Equal(4, result.Value);
			//Assert.Null(result);
		}

		/// <summary>
		/// Test whether can return node not at either end of linked list
		/// </summary>
		[Fact]
		public void CanReturnNodeNotAtEitherEndOfList()
		{
			// Arrange
			LList newList = new LList();
			for (int i = 0; i < 5; i++)
			{
				newList.Insert(i + 1);
			}

			// Act
			Node result = newList.GetKthNodeFromEnd(2);

			// Assert
			Assert.Equal(2, result.Value);
		}

		/// <summary>
		/// Tests whether can determine a linked list with even no. of nodes is circular
		/// </summary>
		[Fact]
		public void CanReturnTrueIfEvenListIsCircular()
		{
			// ARRANGE

			LList list = new LList();

			// Populate list with 4 nodes
			for (int i = 0; i < 4; i++)
			{
				list.Insert(i + 1);
			}
			// Make circular reference: last node in list points back to head
			list.Head.Next.Next.Next.Next = list.Head;

			// ACT
			bool circular = list.IsCircular();

			// ASSERT
			Assert.True(circular);
		}

		/// <summary>
		/// Tests whether can determine a linked list with odd no. of nodes is circular
		/// </summary>
		[Fact]
		public void CanReturnTrueIfOddListIsCircular()
		{
			// ARRANGE

			LList list = new LList();

			// Populate list with 5 nodes
			for (int i = 0; i < 5; i++)
			{
				list.Insert(i + 1);
			}
			// Make circular reference: last node in list points back to head
			list.Head.Next.Next.Next.Next.Next = list.Head;

			// ACT
			bool circular = list.IsCircular();

			// ASSERT
			Assert.True(circular);
		}

		/// <summary>
		/// Tests whether can determine a linked list with odd no. of nodes is not circular
		/// </summary>
		[Fact]
		public void CanReturnFalseIfOddListNotCircular()
		{
			// Arrange
			LList list = new LList();
			for (int i = 0; i < 7; i++)
			{
				list.Insert(i + 1);
			}

			// Act
			bool notCirc = list.IsCircular();

			// Assert
			Assert.False(notCirc);
		}

		/// <summary>
		/// Tests whether can determine a linked list with even no. of nodes is not circular
		/// </summary>
		[Fact]
		public void CanReturnFalseIfEvenListNotCircular()
		{
			// Arrange
			LList list = new LList();
			for (int i = 0; i < 6; i++)
			{
				list.Insert(i + 1);
			}

			// Act
			bool notCirc = list.IsCircular();

			// Assert
			Assert.False(notCirc);
		}

		/// <summary>
		/// Tests whether IsCircular method can return false if list is empty
		/// </summary>
		[Fact]
		public void CanReturnFalseIfListIsEmpty()
		{
			// Arrange
			LList list = new LList();

			// Act
			bool notCirc = list.IsCircular();

			// Assert
			Assert.False(notCirc);
		}

		// Happy path: return correct node at start of loop in linked list with EVEN number of nodes
		[Fact]
		public void CanFindStartOfLoopInLinkedListOfEvenLength()
		{
			// ARRANGE
			LList list = new LList();
			for (int i = 0; i < 6; i++)
			{
				list.Append(i + 1);
			}
			Node end = list.GetKthNodeFromEnd(1); // Get last node in list
			end.Next = list.Head.Next.Next;       // Make list circular

			// ACT
			Node start = list.FindLoopStart();

			// ASSERT
			Assert.Equal(3, start.Value);
		}

		// Happy path: return correct node at start of loop in linked list with ODD number of nodes
		[Fact]
		public void CanFindStartOfLoopInLinkedListOfOddLength()
		{
			// ARRANGE
			LList list = new LList();
			for (int i = 0; i < 7; i++)
			{
				list.Append(i + 1);
			}
			Node end = list.GetKthNodeFromEnd(1); // Get last node in list
			end.Next = list.Head.Next.Next;       // Make list circular

			// ACT
			Node start = list.FindLoopStart();

			// ASSERT
			Assert.Equal(3, start.Value);
		}

		// Expected failure: return null if list with EVEN number of nodes is not circular
		[Fact]
		public void CanReturnNullIfNoLoopInListOfEvenLength()
		{
			// ARRANGE
			LList list = new LList();
			for (int i = 0; i < 6; i++)
			{
				list.Append(i + 1);
			}

			// ACT
			Node start = list.FindLoopStart();

			// ASSERT
			Assert.Null(start);
		}

		// Expected failure: return null if list with ODD number of nodes is not circular
		[Fact]
		public void CanReturnNullIfNoLoopInListOfOddLength()
		{
			// ARRANGE
			LList list = new LList();
			for (int i = 0; i < 7; i++)
			{
				list.Append(i + 1);
			}

			// ACT
			Node start = list.FindLoopStart();

			// ASSERT
			Assert.Null(start);
		}

		// Return start of loop in linked list of only 1 node
		[Fact]
		public void CanFindStartOfLoopInLinkedListWithOnlyOneNode()
		{
			// ARRANGE
			LList list = new LList();
			list.Append(1); // Make list contain only 1 node
			list.Head.Next = list.Head; // Make list circular

			// ACT
			Node start = list.FindLoopStart();

			// ASSERT
			Assert.Equal(1, start.Value);
		}

		// Return start of loop in linked list of only 2 nodes
		[Fact]
		public void CanFindStartOfLoopInLinkedListWithOnlyTwoNodes()
		{
			// ARRANGE
			LList list = new LList();
			list.Append(1); 
			list.Append(2);
			Node end = list.GetKthNodeFromEnd(1); // Get last node in list
			end.Next = list.Head; // Make list circular

			// ACT
			Node start = list.FindLoopStart();

			// ASSERT
			Assert.Equal(1, start.Value);
		}

		// Return start of loop when it's first node in list
		[Fact]
		public void CanFindStartOfLoopInLinkedListWhenLoopStartIsFirstNode()
		{
			// ARRANGE
			LList list = new LList();
			for (int i = 0; i < 5; i++)
			{
				list.Append(i + 1);
			}
			Node end = list.GetKthNodeFromEnd(1); // Get last node in list
			end.Next = list.Head.Next.Next;       // Make list circular

			// ACT
			Node start = list.FindLoopStart();

			// ASSERT
			Assert.Equal(3, start.Value);
		}

		// Return start of loop when it's last node in list
		[Fact]
		public void CanFindStartOfLoopInLinkedListWhenLoopStartIsLastNode()
		{
			// ARRANGE
			LList list = new LList();
			for (int i = 0; i < 5; i++)
			{
				list.Append(i + 1);
			}
			Node end = list.GetKthNodeFromEnd(1); // Get last node in list
			end.Next = end; // Make list circular

			// ACT
			Node start = list.FindLoopStart();

			// ASSERT
			Assert.Equal(5, start.Value);
		}
	}
}
