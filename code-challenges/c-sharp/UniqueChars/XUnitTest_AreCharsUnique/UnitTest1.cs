using System;
using UniqueChars;
using Xunit;

namespace XUnitTest_AreCharsUnique
{
	public class UnitTest1
	{
		/// <summary>
		/// Tests whether can return true when all chars are unique (happy path)
		/// </summary>
		[Fact]
		public void CanReturnTrueWhenAllCharsUnique()
		{
			// Arrange
			string trueStr = "abcdefg";

			// Act
			bool expectedTrue = Program.AreCharactersUnique(trueStr);

			// Assert
			Assert.True(expectedTrue);
		}

		/// <summary>
		/// Tests whether can return false when only one of the duplicate chars is at end of string
		/// </summary>
		[Fact]
		public void CanReturnFalseWhenDuplicateCharAtEndOfString()
		{
			// Arrange
			string falseStr = "abcdefgd";

			// Act
			bool expectedFalse = Program.AreCharactersUnique(falseStr);

			// Assert
			Assert.False(expectedFalse);
		}

		/// <summary>
		/// Tests whether can return false when both of the duplicate chars are at end of string
		/// </summary>
		[Fact]
		public void CanReturnFalseWhenBothDuplicateCharAtEndOfString()
		{
			// Arrange
			string falseStr = "abcdeff";

			// Act
			bool expectedFalse = Program.AreCharactersUnique(falseStr);

			// Assert
			Assert.False(expectedFalse);
		}
	}
}
