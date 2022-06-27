public static class Problem4
{
    // Largest Palindrome Product

    // A palindromic number reads the same both ways.
    // The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
    // Find the largest palindrome made from the product of two 3-digit numbers.

    public static int LargestPalendromeProduct(int from, int upTo)
    {
        int i, x, num;
        List<int> products = new List<int>();

        for (i = upTo; i > from; i--)
        {
            for (x = upTo; x > from; x--)
            {
                num = (i * x).ToString().Reverse().Aggregate(0, (b, x) => 10 * b + x - '0');
                products.Add(Convert.ToInt32((i * x) == num) * num);
            }
        }

        return products.Max();
    }
}