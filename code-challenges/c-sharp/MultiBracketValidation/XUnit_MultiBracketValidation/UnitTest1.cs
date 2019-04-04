using System;
using Xunit;

namespace XUnit_MultiBracketValidation
{
	public class UnitTest1
	{

		/// <summary>
		/// Tests whether MultiBracketValidation method can correctly return true or false
		/// </summary>
		/// <param name="pattern"></param>
		/// <param name="expectedBool"></param>
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

		public void CanMultiBracketValidationMethodCorrectlyReturnTrueAndFalse(string pattern, bool expectedBool)
		{
			// Arrange

			// Act

			// Assert

		}
	}
}
