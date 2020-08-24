using System;
using System.Linq;
using System.Collections.Generic;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {

            var removeNonChar = phrase.ToUpper().Replace("_","").Replace("-", " ");
            string[] splitPhases = removeNonChar.Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries);
            var madeArray = splitPhases.Where(s => !string.IsNullOrEmpty(s)).Select(c => c[0]).Where(c => (char.IsLetterOrDigit(c)));
            var concatChr = String.Concat(madeArray);
            return concatChr;




            /*
            string capPhrase = phrase.ToUpper().Replace("-", " ");
            char[] arr = capPhrase.ToCharArray();
            arr = Array.FindAll<char>(arr, (c => (char.IsLetterOrDigit(c)
                                              || char.IsWhiteSpace(c)
                                              )));
            var str = new string(arr);


            string[] splitPhrases = str.Split(' ');
            string output = "";

            foreach (string splitPhrase in splitPhrases)
            {
                if (String.IsNullOrEmpty(splitPhrase))
                    continue;

                output += splitPhrase[0];

            }
            Console.WriteLine(output);
            return output;
            */
        }
        
}

//dotnet watch test