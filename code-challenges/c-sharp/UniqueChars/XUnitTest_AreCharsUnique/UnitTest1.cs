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

			// Act
			bool expectedTrue = Program.AreCharactersUnique(trueStr);

			// Assert
			Assert.True(expectedTrue);
		}
	}
}
