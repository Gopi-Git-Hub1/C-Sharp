using System.IO;
using System;
namespace factorial_of_a_number
{
	class factorial
	{
		int factorialNumber(int n)
		{
			int fact=1;
			for(int i =1;i<=n;i++)
			{
				fact *= i;
			}
			return fact;
		}
		static void Main(string[] args)
		{
			Console.Write("Enter the number :");
			int num = Convert.ToInt32(Console.ReadLine());
			factorial obj = new factorial();
			int res = obj.factorialNumber(num);
			Console.WriteLine("factorial_of_a_number "+ num +" is : " +res);
		}
	}
}
