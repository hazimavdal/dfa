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

    // This DFA checks if a string s∈{a,b}* has an odd
    // number of a's and at most 4 b's.
    public static DFA<char> OddMax = new DFA<char>()
    {
        Q = new HashSet<string>
        {
            "aL0", "aL1", "aL2", "aL3", "aL4",
            "bL0", "bL1", "bL2", "bL3",
            "aR0", "aR1", "aR2", "aR3", "aR4",
            "bR0", "bR1", "bR2", "bR3", "rabbit_hole"
        },

        Σ = new HashSet<char> { 'a', 'b' },
        δ = new Dictionary<(string, char), string>
            {
                {("aL0", 'a'), "aR0"},
                {("aL1", 'a'), "aR1"},
                {("aL2", 'a'), "aR2"},
                {("aL3", 'a'), "aR3"},
                {("aL4", 'a'), "aR4"},
                {("aL0", 'b'), "bL0"},
                {("aL1", 'b'), "bL1"},
                {("aL2", 'b'), "bL2"},
                {("aL3", 'b'), "bL3"},
                {("aL4", 'b'), "rabbit_hole"},

                {("bL0", 'a'), "aR1"},
                {("bL1", 'a'), "aR2"},
                {("bL2", 'a'), "aR3"},
                {("bL3", 'a'), "aR4"},
                {("bL0", 'b'), "bL1"},
                {("bL1", 'b'), "bL2"},
                {("bL2", 'b'), "bL3"},
                {("bL3", 'b'), "rabbit_hole"},

                {("bR0", 'a'), "aL1"},
                {("bR1", 'a'), "aL2"},
                {("bR2", 'a'), "aL3"},
                {("bR3", 'a'), "aL4"},
                {("bR0", 'b'), "bR1"},
                {("bR1", 'b'), "bR2"},
                {("bR2", 'b'), "bR3"},
                {("bR3", 'b'), "rabbit_hole"},

                {("aR0", 'a'), "aL0"},
                {("aR1", 'a'), "aL1"},
                {("aR2", 'a'), "aL2"},
                {("aR3", 'a'), "aL3"},
                {("aR4", 'a'), "aL4"},
                {("aR0", 'b'), "bR0"},
                {("aR1", 'b'), "bR1"},
                {("aR2", 'b'), "bR2"},
                {("aR3", 'b'), "bR3"},
                {("aR4", 'b'), "rabbit_hole"},

                {("rabbit_hole", 'a'), "rabbit_hole"},
                {("rabbit_hole", 'b'), "rabbit_hole"},
            },
        q0 = "aL0",
        F = new HashSet<string> { "aR0", "aR1", "aR2", "aR3", "aR4", "bR0", "bR1", "bR2", "bR3" }
    };
}

