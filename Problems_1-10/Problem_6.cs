public static class Problem6
{
    // Sum Square Difference

    // The sum of the squares of the first ten natural numbers is,
    // 12 + 22 + ... + 102 = 385
    // The square of the sum of the first ten natural numbers is,
    // (1 + 2 + ... + 10)^2 = 55^2 = 3025
    // Hence the difference between the sum of the squares of
    // the first ten natural numbers and the square of the sum is 
    // 3025 − 385 = 2640.
    // Find the difference between the sum of the squares of 
    // the first one hundred natural numbers and the square of the sum.

    public static double SumSquareDifference(int upTo)
    {
        double diff, sumSquare = 0, squareSum = 0;

        for (int i = 1; i <= upTo; i++)
        {
            sumSquare += Math.Pow(i, 2);
            squareSum += i;
        }

        squareSum = Math.Pow(squareSum, 2);
        diff = squareSum - sumSquare;

        return diff;
    }
}