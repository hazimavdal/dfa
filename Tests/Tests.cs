using System;
using System.Linq;
using System.Diagnostics;
using System.Collections.Generic;

public static class Tests
{
    public static void TestTwoOrThreeStar()
    {
        bool expected, actual;
        var samples = new[] { 'a', 'a' }.GetSamples(n: 100000, p: 0.5);
        samples.Add(new List<char>());

        foreach (var sample in samples)
        {
            expected = sample.Count == 2 || (sample.Count % 3) == 0;

            actual = Examples.TwoOrThreeStar.Read(sample);
            Debug.Assert(actual == expected);
        }

        Console.WriteLine("TwoOrThreeStar passed all the tests.");
    }


    public static void TestDivisibleByThree()
    {
        bool expected, actual;

        for (int i = 0; i < 100000; i++)
        {
            expected = i % 3 == 0;
            actual = Examples.DivisibleByThree.Read(i.GetBits());
            Debug.Assert(actual == expected);
        }

        Console.WriteLine("DivisibleByThree passed all the tests.");
    }

    public static void TestEvenParity()
    {
        bool expected, actual;

        for (int i = 0; i < 100000; i++)
        {
            expected = i.GetParity() == 0;
            actual = Examples.EvenParity.Read(i.GetBits());
            Debug.Assert(actual == expected);
        }

        Console.WriteLine("EvenParity passed all the tests.");
    }

    public static void TestOddMax()
    {
        bool expected, actual;

        var samples = Examples.OddMax.Σ.ToArray().GetSamples(n: 100000, p: 0.05);

        foreach (var sample in samples)
        {
            expected = sample.Where(c => c == 'b').Count() <= 4 &&
                sample.Where(c => c == 'a').Count() % 2 == 1;

            actual = Examples.OddMax.Read(sample);
            Debug.Assert(actual == expected);
        }


        Console.WriteLine("OddMax passed all the tests.");
    }
}