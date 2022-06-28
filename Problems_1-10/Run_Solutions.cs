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
            case 1: Console.WriteLine(Problem1.SumMultiplesof3and5(1000)); break;
            case 2: Console.WriteLine(Problem2.SumEvenFib(4000000)); break;
            case 3: Console.WriteLine(Problem3.LargestPrimeFactor(600851475143)); break;
            case 4: Console.WriteLine(Problem4.LargestPalendromeProduct(99, 999)); break;
            case 5: Console.WriteLine(Problem5.SmallestMultiple(20)); break;
            case 6: Console.WriteLine(Problem6.SumSquareDifference(100)); break;
            default: break;
        }
    }
}