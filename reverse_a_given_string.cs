using System.IO;
using System;
namespace reverse_a_given_string
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Eneter the string:");
			string str = Console.ReadLine();
			char[] arr = str.ToCharArray();
			Array.Reverse(arr);
			string reverseString = new string(arr);
			Console.WriteLine(reverseString);

		}
	}
}
