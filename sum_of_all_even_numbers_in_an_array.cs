using System.IO;
using System;
namespace sum_of_all_even_numbers_in_an_array
{
	class sumOfAllEvenNumbersInAnArray
	{
		int SumOfAllEvenNumbersInAnArray(int[] arr)
		{
			int sum =0;
			for(int i =0; i<arr.Length;i++)
			{
				if(arr[i]%2==0)
					sum += arr[i];
			}
			return sum;
		}
		static void Main(string[] args)
		{
			int[] ar={1,2,3,4,5,6,7,8,9,10};
			sumOfAllEvenNumbersInAnArray obj = new sumOfAllEvenNumbersInAnArray();
			int res = Convert.ToInt32(obj.SumOfAllEvenNumbersInAnArray(ar));
			Console.WriteLine("sum_of_all_even_numbers_in_an_array is : "+ res);
		}
	}
}
