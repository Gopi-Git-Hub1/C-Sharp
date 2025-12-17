using System;

namespace string_concat
{
	class strCat
	{
		static void Main(String[] args)
		{
			Console.Write("Enter first string : ");
			string str1 = Console.ReadLine();
			Console.Write("Enter second string : ");
			string str2 = Console.ReadLine();
			string strConcat1 = str1 + str2;
			Console.WriteLine("strConcat1 : "+strConcat1);
			Console.Write("Enter first string : ");
			string str3 = Console.ReadLine();
			Console.Write("Enter second string : ");
			string str4 = Console.ReadLine();
			string strConcat2 = string.Concat(str3, str4);
			Console.WriteLine("strConcat2 : "+strConcat2);
		}
	}
}
