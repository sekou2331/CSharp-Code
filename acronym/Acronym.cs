using System;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {

            string capPhrase = phrase.ToUpper();
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
        }
}

//dotnet watch test