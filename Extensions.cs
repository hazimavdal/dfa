using System.Collections.Generic;

public static class Extensions
{
    const uint INT_SIZE = 32;
    private static System.Random RandomEngine = new System.Random();

    public static List<int> GetBits(this int n)
    {
        var result = new List<int>();

        for (uint i = 0; i < INT_SIZE; i++)
        {
            result.Add(n & 1);
            n = n >> 1;
        }

        return result;
    }

    public static int GetParity(this int n)
    {
        var ones = 0;

        for (uint i = 0; i < INT_SIZE; i++)
        {
            ones += n & 1;
            n = n >> 1;
        }

        return ones % 2;
    }

    public static List<char> GetSample(this char[] symbols, double p = 0.5)
    {
        var result = new List<char>();
        var size = RandomEngine.Next(100);

        for (int i = 0; i < size; i++)
            result.Add(RandomEngine.NextDouble() > p ? symbols[0] : symbols[1]);

        return result;
    }

    public static List<List<char>> GetSamples(this char[] symbols, int n, double p = 0.5)
    {
        var result = new List<List<char>>();
        for (int i = 0; i < n; i++)
            result.Add(symbols.GetSample(p));

        return result;
    }
}