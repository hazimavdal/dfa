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

    // This DFA checks if a number has even parity.
    public static DFA<int> EvenParity = new DFA<int>()
    {
        Q = new HashSet<string> { "Yes", "No" },
        Σ = new HashSet<int> { 0, 1 },
        δ = new Dictionary<(string, int), string>
            {
                {("Yes", 0), "Yes"},
                {("Yes", 1), "No"},
                {("No", 0), "No"},
                {("No", 1), "Yes"},
            },
        q0 = "Yes",
        F = new HashSet<string> { "Yes" }
    };

}

