using System;

public enum Classification {
    Perfect,
    Abundant,
    Deficient
}

public static class PerfectNumbers {
    public static Classification Classify (int number) {

        if (number <= 0)
            throw new ArgumentOutOfRangeException ();

        int sum = 0;
        for (int i = 0; i < number; i++) {
            if (i == 0) {
                continue;
            }
            int numCheck = number % i;

            if (numCheck == 0) {
                sum += i;

            }
        }

        if (sum > number) {

            Console.WriteLine ("**Abundant**: aliquot sum > number");
            return Classification.Abundant;
        } else if (sum < number) {

            Console.WriteLine ("**Deficient**: aliquot sum < number");
            return Classification.Deficient;
        }

        return Classification.Perfect;;

    }
}