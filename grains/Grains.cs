using System;

public static class Grains
{
        public static ulong Square(int n)
        {
        if (n < 1 || n > 64)
        throw new ArgumentOutOfRangeException("The number given is either a zero or a negative number and cant be used");


        return (ulong)1 << (n - 1);

        }

        public static ulong Total()
        {
            ulong sum = 0;
            for (var i = 1; i <= 64; i++)
            {
                sum += Square(i);
            }
            return sum;
        }
}