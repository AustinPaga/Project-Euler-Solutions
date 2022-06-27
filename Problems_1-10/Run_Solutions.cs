using System;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;

public class Run_Solutions
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Which problem to solve?: ");

        int selectedProblem = Convert.ToInt32(Console.ReadLine());

        SolveProblem(selectedProblem);
    }

    private static void SolveProblem(int problemNum)
    {
        switch (problemNum)
        {
            case 1: Console.WriteLine(Problem1.SumMultiplesof3and5(1000)); break;
            case 2: Console.WriteLine(Problem2.SumEvenFib(4000000)); break;
            default: break;
        }
    }
}