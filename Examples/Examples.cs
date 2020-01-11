using DFA;
using System.Collections.Generic;

public static class Examples
{
    // This DFA checks if a number is divisible by 3.
    public static DFA<int> DivisibleByThree = new DFA<int>()
    {
        Q = new HashSet<string> { "0", "1", "2" },
        Σ = new HashSet<int> { 0, 1 },
        δ = new Dictionary<(string, int), string>
            {
                {("0", 0), "0"},
                {("0", 1), "1"},
                {("1", 0), "2"},
                {("1", 1), "0"},
                {("2", 0), "1"},
                {("2", 1), "2"},
            },
        q0 = "0",
        F = new HashSet<string> { "0" }
    };
}

