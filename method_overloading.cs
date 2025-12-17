using System;
namespace methods
{
	class method_overloading
	{
		static int sum(int a, int b)
		{
			return a+b;
		}
		static double sum(double x, double y)
		{
			return x+y;
		}
		static void Main(string[] args)
		{
			int Sum = sum(10,20);
			double Add = sum(10.5,19.5);
			Console.WriteLine("int Sum : "+Sum+"\ndouble Sum : "+Add);
		}
	}
}
