using System;
class fruty
{
	protected string f1;
	public fruty()
	{
		f1 = "Mango";
	}
		public virtual void display()
		{
			Console.WriteLine(f1);
		}

}
namespace fruit
{
	class fruits : fruty
	{
		private string f2;
		public fruits()
		{
			f2 = "Apple";
		}
		public override void display()
		{
			Console.WriteLine(f2);
		}
		static void Main(string[] args)
		{
			fruits Obj1 = new fruits();
			Obj1.display();
			fruty Obj2 = new fruty();
			Obj2.display();


		}
	}
}
