using System;
					
public class Program
{
	public static void Main()
	{
		//For string interpolation to work, you need to choose the .Net Core compiler in .Net Fiddle
		
		string firstName = "oscar";
		string lastName = "loyno";
		
		//This uses composite formatting
		Console.WriteLine("Hello {0} {1} using composite formatting", firstName, lastName);
		
		//This uses string interpolation. Note the dollar sign
		Console.WriteLine($"Hello {firstName} {lastName}");

		//Different data types. 
		//item is a named tuple
		var item = (Name: "eggplant", Price: 1.99m, perPackage: 3);
		var date = DateTime.Now;
		Console.WriteLine($"On {date}, the price of {item.Name} was {item.Price:C2} per {item.perPackage} items.");
	}
}