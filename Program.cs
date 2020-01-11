using System;

class Program
{
    static void Main(string[] args)
    {
        var dfa = Examples.DivisibleByThree;
        var word = 9009231.GetBits();

        Console.WriteLine("L(A) Acceptance: {0}", dfa.Read(word).ToString());

        Tests.TestDivisibleByThree();
        Tests.TestEvenParity();
        Tests.TestOddMax();
    }
}
