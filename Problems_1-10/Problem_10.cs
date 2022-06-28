public static class Problem10
{
    // Summation of Primes

    // The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
    // Find the sum of all the primes below two million.

    public static double PrimeSum(double below)
    {
        double sum = 0;
        bool isPrime;
        List<double> primes = new List<double>();

        if (below >= 3)
        {
            primes.Add(2);
            sum = 2;
        }

        for (double i = 3; i < below; i++)
        {
            isPrime = true;

            foreach (double x in primes)
            {
                if (i % x == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                primes.Add(i);
                sum += i;
            }
        }

        return sum;
    }
}