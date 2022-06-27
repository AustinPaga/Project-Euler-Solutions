public static class Problem3
{
    // Largest Prime Factors

    // The prime factors of 13195 are 5, 7, 13 and 29.
    // What is the largest prime factor of the number 600851475143 ?

    public static long? LargestPrimeFactor(long number)
    {
        long? maxPrime = null, num = number, k, i, epsilon = 2;
        bool isPrimeFactor = false, isPrime, isNotFactor;

        for (i = num / epsilon; i > 0 && !isPrimeFactor; i = num / epsilon)
        {
            isPrime = true;

            if (num % i == 0)
            {
                for (k = 2; k <= i / 2 && isPrime; k++)
                {
                    isPrime = i % k != 0;
                }

                if (isPrime)
                {
                    maxPrime = ((Convert.ToInt32(i == 1) * num) + (Convert.ToInt32(i != 1) * i));
                    isPrimeFactor = true;
                }
            }

            isNotFactor = true;

            for (long j = (long)epsilon + 1; j < num / 2 && isNotFactor; j++)
            {
                if (num % j == 0)
                {
                    epsilon = j;
                    isNotFactor = false;
                }
            }
        }

        return maxPrime;
    }
}