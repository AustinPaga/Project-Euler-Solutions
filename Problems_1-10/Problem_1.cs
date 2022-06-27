public static class Problem1
{
    // Multiples of 3 or 5

    // If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9.
    // The sum of these multiples is 23.
    // Find the sum of all the multiples of 3 or 5 below 1000.

    public static long SumMultiplesof3and5(int below)
    {
        int sum = 0;

        for (int i = 3; i < below; i++) 
        {
            sum += (Convert.ToInt32(i % 3 == 0 || i % 5 == 0) * i);
        }

        return sum;
    }
}