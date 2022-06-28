public static class Problem7
{
    // 10001st Prime

    // By listing the first  six prime numbers: 2, 3, 5, 7, 11, 13,
    // We can see that the 6th prime is 13.
    // What is the 10,001st prime number?

    public static double _PlacePrime(int place)
    {
        double targetPrime;
        bool isPrime;
        List<int> primeNums = new List<int>();

        for (int i = 2; primeNums.Count < place; i++)
        {
            isPrime  = true;

            foreach (int x in primeNums)
            {
                if (i % x == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                primeNums.Add(i);
            }
        }

        targetPrime = primeNums.Max();
        return targetPrime;
    }
}