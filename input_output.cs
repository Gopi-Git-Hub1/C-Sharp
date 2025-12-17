using System;

namespace input_output
{
	class userDetails
	{
		static void Main(String[] args)
		{
			Console.WriteLine("Enter the User Name : ");
			string userName = Console.ReadLine();
			Console.WriteLine("Enter the User Id : ");
			int userId = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("User Name : "+ userName +"\nUser Id : "+userId);
		}
	}
}
