using System;
					
public class Program
{
	public static void Main()
	{
		//For string interpolation to work, you need to choose the .Net Core compiler in .Net Fiddle
		
		string firstName = "oscar";
		string lastName = "loyno";
		
		//This uses composite formatting
		Console.WriteLine("Hello {0} {1}", firstName, lastName);
		
		//This uses string interpolation. Note the dollar sign
		Console.WriteLine($"Hello {firstName} {lastName}");
	}
}