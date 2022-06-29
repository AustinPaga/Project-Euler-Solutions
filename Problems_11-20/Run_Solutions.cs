using System;

public class Run_Solutions
{
    private static void Main(string[] args)
    {
        Console.Write("Which problem to solve?: ");

        int selectedProblem = Convert.ToInt32(Console.ReadLine());

        SolveProblem(selectedProblem);
    }

    private static void SolveProblem(int problemNum)
    {
        switch (problemNum)
        {
            case 11: Console.WriteLine(Problem11.LargestGridProduct(20, 20, 4)); break;
            //case 2: Console.WriteLine(Problem2.SumEvenFib(4000000)); break;
            //case 3: Console.WriteLine(Problem3.LargestPrimeFactor(600851475143)); break;
            //case 4: Console.WriteLine(Problem4.LargestPalendromeProduct(99, 999)); break;
            //case 5: Console.WriteLine(Problem5.SmallestMultiple(20)); break;
            //case 6: Console.WriteLine(Problem6.SumSquareDifference(100)); break;
            //case 7: Console.WriteLine(Problem7._PlacePrime(10001)); break;
            //case 8: Console.WriteLine(Problem8.LargestSeriesProduct(13)); break;
            //case 9: Console.WriteLine(Problem9.PythagoreanTriplet(1000)); break;
            //case 10: Console.WriteLine(Problem10.PrimeSum(2000000)); break;
            default: Console.WriteLine("Not a valid problem number"); break;
        }
    }
}