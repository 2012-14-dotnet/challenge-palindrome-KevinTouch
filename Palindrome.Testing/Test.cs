using Xunit;
using Palindrome.Client;

namespace Palindrome.Testing
{
	public class Test
	{
		[Fact]
		private void Test_IsPalindrome()
		{
			// edge cases
			// empty string
			bool test1 = Program.IsPalindrome("");
			Assert.True(test1, "empty string should not be false");

			// null string 
			bool test2 = Program.IsPalindrome(null);
			Assert.False(test2, "null string should be false");

			// even string
			bool test3 = Program.IsPalindrome("11/11/11");
			Assert.True(test3, "11/11/11 should be true");

			// odd string
			bool test4 = Program.IsPalindrome("madam");
			Assert.True(test4, "madam should be true");

			// spacing
			bool test5 = Program.IsPalindrome("top spot");
			Assert.True(test5, "top spot should be true");

			// incorrect palindrome
			bool test6 = Program.IsPalindrome("asdf");
			Assert.False(test6, "asdf should be fasle");

			// case sensitive feature addded
			bool test7 = Program.IsPalindrome("");

			// ignore spacing/punctuation feature later?
		}
	}
}