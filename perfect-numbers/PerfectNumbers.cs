using System;

public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}

public static class PerfectNumbers
{
    public static Classification Classify(int number)
    {
            Classification perfect = Classification.Perfect;
            Classification abundant = Classification.Abundant;
            Classification deficient = Classification.Deficient;
                
            int sum = 0;
            if(number <= 0)
                 throw new ArgumentOutOfRangeException("The number given is either a zero or a negative number and cant be used");
            for (int i = 0; i < number; i++)
            {
                if (i == 0)
                {
                    continue;
                }
                int numCheck = number % i;

                if (numCheck == 0)
                {
                    sum += i;

                }

            }

            

            if (sum > number)
            {
                
                Console.WriteLine("**Abundant**: aliquot sum > number");
                return  abundant;
            }
            else if (sum < number)
            {
                
                Console.WriteLine("**Deficient**: aliquot sum < number");
               return deficient;
            }
                return perfect;
           
    }
}
