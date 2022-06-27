using System;
public static class Problem3
{
    // Largest Prime Factors

    // The prime factors of 13195 are 5, 7, 13 and 29.
    // What is the largest prime factor of the number 600851475143 ?

    public static long? LargestPrimeFactor(int number)
    {
        long? maxPrime = null, num = number, k, i;
        bool isPrime = true, again, repeat = true, loop;

        for (i = num / 2; i > 0 && repeat; i--)
        {
            (isPrime, again) = (true, true);

            loop = (num % i == 0);

            for (k = 2; k <= i / 2 && again && loop; k++)
                (isPrime, again) = (i % k != 0, i % k != 0);
            
            (maxPrime, repeat) = ((Convert.ToInt32(i == 1) * num) + (Convert.ToInt32(i != 1) * i), !(isPrime && loop));
        }

        return maxPrime;
    }
}