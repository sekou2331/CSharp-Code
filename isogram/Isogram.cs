using System;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        if (string.IsNullOrEmpty(word))
            return true;
        
        
        char previousLetter = word[0];
        for (int i = 1; i < word.Length; i++)
        {

            if (word[i] == previousLetter)
            {
                return true;
            }
            else { previousLetter = word[i]; }
        }
  
       return true;
    }
}
//dotnet watch test