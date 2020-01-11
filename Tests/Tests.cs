using System;
using System.Diagnostics;

public static class Tests
{
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
}