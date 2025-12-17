using System;
namespace class_object
{
	class Car
	{
		string color = "Black";
		void display()
		{
			Console.WriteLine(color);
		}
		static void Main(string[] args)
		{
			Car Obj = new Car();
			Obj.display();
			Obj.color = "Red";
			Obj.display();
		}
	}
}
