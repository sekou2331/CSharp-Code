using System;

public static class Pangram
{
	public static bool IsPangram(string input)
		{
		bool[] marked = new bool[26];

		int index = 0;
		string newIput = input.ToUpper();

		for(int i = 0; i < newIput.Length; i++)
			{
				if ('A' <= newIput[i] && newIput[i] <= 'Z')
				{

					index = newIput[i] - 'A';

				}else{
				continue;

				}
				marked[index] = true; 

			}
		for (int i = 0; i <= 25; i++) 
		if (marked[i] == false) 
		return (false); 


		return (true); 

	}
}
  
