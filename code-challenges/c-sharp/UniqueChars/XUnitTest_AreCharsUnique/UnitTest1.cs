using System;
using UniqueChars;
using Xunit;

namespace XUnitTest_AreCharsUnique
{
	public class UnitTest1
	{
		[Fact]
		public void CanReturnTrueWhenAllCharsUnique()
		{
			// Arrange
			string trueStr = "abcdefg";
			string falseStr = "abcaefge";

			// Act
			bool expectedTrue = Program.AreCharactersUnique(trueStr);

			// Assert
			Assert.True(expectedTrue);
		}

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
	}
}
