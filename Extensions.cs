using System.Collections.Generic;

public static class Extensions
{
    const uint INT_SIZE = 32;

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
}