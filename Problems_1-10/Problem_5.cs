public static class Problem5
{
    // Smallest Multiple

    // 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
    // What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?

    public static int SmallestMultiple(int upTo)
    {
        int multiple = 1, l = 0;
        List<int> numList = new List<int>(){2};
        bool isPrime = true;

        for (int i = 3; i <= upTo; i++)
        {
            isPrime = true;
            foreach (int x in numList)
            {
                if (i % x == 0)
                {
                    double quotient = x, divisor = i, dividend2 = x;
                    
                    for (l = 1; quotient > 1; l++)
                    {
                        quotient = (double)divisor / dividend2;
                        divisor = quotient;
                        numList.RemoveAll(item => item == Convert.ToInt32(quotient == 1) * x);
                        numList.AddRange(Enumerable.Repeat(x, Convert.ToInt32(quotient == 1) * l));
                    }

                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
                numList.Add(i);
        }
        foreach (int y in numList)
            multiple *= y;

        return multiple;
    }
}