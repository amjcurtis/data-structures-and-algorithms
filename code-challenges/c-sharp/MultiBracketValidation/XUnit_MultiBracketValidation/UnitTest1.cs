using System;
using Xunit;

namespace XUnit_MultiBracketValidation
{
	public class UnitTest1
	{
		[Theory]
		[InlineData("{}", true)]
		[InlineData("{}(){}", true)]
		[InlineData("()[[Extra Characters]]", true)]
		[InlineData("(){}[[]]", true)]
		[InlineData("{}{Code}[Fellows](())", true)]
		[InlineData("[({}]", false)]
		[InlineData("(](", false)]
		[InlineData("{(})", false)]
		[InlineData("{", false)]
		[InlineData(")", false)]
		[InlineData("[}", false)]
		public void Test1(string pattern, bool expectedBool)
		{

		}
	}
}
