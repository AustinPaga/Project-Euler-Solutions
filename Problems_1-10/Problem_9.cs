public static class Problem9
{
    // Special Pythagorean Triplet

    // A Pythagorean triplet is a set of three natural numbers,
    // a < b < c, for which,
    // a^2 + b^2 = c^2
    // For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2.
    // There exists only one Pythagorean triplet for which a + b + c = 1000.
    // Find the product abc.

    public static double PythagoreanTriplet(int sum)
    {
        double product = 0, a, b, c;
        bool again = true;

        for (a = 1; a < sum - 4 && again; a++)
        {
            for (b = a + 1; b < sum - 4 && again; b++)
            {
                c = sum - a - b;

                if (a + b + c == sum && Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b, 2))
                {
                    product = a * b * c;
                    again = false;
                }
            }
        }

        return product;
    }
}