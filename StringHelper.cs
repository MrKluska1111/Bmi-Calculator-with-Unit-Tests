using System;
using System.Linq;

public static class StringHelper
{
	public static string ReverseWords(string str)
	{
		//ala ma kota => kota ma ala

		var splitWords = str.Split(' ');
		var reverseWords = splitWords.Reverse();
		var result = string.Join(' ', reverseWords);

		return result;
	}

	public static bool IsPalindrome(string str)
	{
		//ola => false
		//ala => true
		//Ala => false

		return str.SequenceEqual(str.Reverse());
	}
}
