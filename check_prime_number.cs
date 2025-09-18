using System.IO;
using System;

namespace check_prime_umber
{
	class Prime
	{
		bool isprime(int n)
		{
			bool flag = true;
			if(n<=1)
				return false;
			for(int i =2; i<=Math.Sqrt(n);i++)
			{
				if(n%i==0)
					flag = false;
			}
			return flag;
		}
		static void Main(string[] args)
		{
			Console.Write("Enter the number :");
			int num = Convert.ToInt32(Console.ReadLine());
			Prime obj = new Prime();
			bool res = obj.isprime(num);
			if(res)
			{
				Console.WriteLine(num +" is a prime");
			}
			else
			{
				Console.WriteLine(num +" is not a prime");
			}

		}
	}
}
