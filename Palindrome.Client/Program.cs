using System;

namespace Palindrome.Client
{
	public class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter a word or sentence!");
			string s = Console.ReadLine();
			bool b = IsPalindrome(s);
			string ans = b ? "a palindrome!" : "not a palindrome!";
			Console.WriteLine("The word/sentence that you wrote is " + ans);
		}

		public static bool IsPalindrome(string s)
		{
			for (int i = 0, sz = s.Length; i < sz / 2; ++i)
			{
				if (s[i] != s[sz - i - 1])
				{
					return false;
				}
			}
			return true;
		}
	}
}
