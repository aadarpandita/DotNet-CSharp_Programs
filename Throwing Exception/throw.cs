using System;
public class Custom : Exception
{
}
public class TestException
{
	 public static void Main()
	{	
		int num;
		Console.WriteLine("Enter a number : ");
		num = int.Parse(Console.ReadLine());
			try{
				if(num % 2 == 0)
				Console.WriteLine("No exception is found");
				else
				throw new Custom();
			}
			catch(Custom e)
			{
				Console.WriteLine("Exception Occured : Number isn't an even number \t" + e.Message);
			}
	}
}
