using System;
using System.Linq;
using System.Collections.Generic;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        var capWord = word.ToUpper();
        var checkForAlphas = capWord.Where(c => Char.IsLetter(c)).ToArray();
        var set = new HashSet<Char>(checkForAlphas);
        var check = checkForAlphas.Length == set.Count();
        var output = (check) ? true : false;
        return output;



    }
}
//dotnet watch test