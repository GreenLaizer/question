using System;

class MainClass
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Enter your name ?");
		string name = Console.ReadLine();
		Console.WriteLine("Enter your age ?");
		byte age = byte.Parse(Console.ReadLine());
		Console.WriteLine("Your name is {0} and age is {1}", name, age);
		Console.WriteLine("Enter your birtdate ?");
		var birthdate = Console.ReadLine();
		Console.WriteLine("Your birtdate is " + birthdate);
		Console.ReadLine();

		

	}
}


