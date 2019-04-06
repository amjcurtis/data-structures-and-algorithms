using System;
using MultiBracketValidation;
using Xunit;

namespace XUnit_MultiBracketValidation
{
	public class UnitTest1
	{

		/// <summary>
		/// Tests whether MultiBracketValidation method can correctly return true or false
		/// </summary>
		/// <param name="input">string</param>
		/// <param name="expectedBool">boolean</param>
		[Theory]
		// Return true
		[InlineData("{}", true)]
		[InlineData("{}(){}", true)]
		[InlineData("()[[Extra Characters]]", true)]
		[InlineData("(){}[[]]", true)]
		[InlineData("{}{Code}[Fellows](())", true)]
		// Return false
		[InlineData("[({}]", false)]
		[InlineData("(](", false)]
		[InlineData("{(})", false)]
		[InlineData("{", false)]
		[InlineData("[}", false)]
		// Edge case: first bracket in string is a closing bracket
		[InlineData(")", false)]

		public void CanMultiBracketValidationMethodCorrectlyReturnTrueAndFalse(string input, bool expectedBool)
		{
			// Arrange

			// Act
			bool actualBool = Program.MultiBracketValidation(input);
			// Assert
			Assert.Equal(actualBool, expectedBool);
		}
	}
}
