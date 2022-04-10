using System;
					
public class Program
{
	public static void Main()
	{	
		int sums = 0;
		int max = 100;

		for(int i = 1; i < max; i++){
			if ((i % 3) == 0 || (i % 5) == 0){
				sums += i;
			}
		}

		Console.WriteLine(String.Concat("The sums of every number below ", max, " that are multiple of 3 and 5 is: ", sums));
	}
}