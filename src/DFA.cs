using System.Diagnostics;
using System.Collections.Generic;

namespace DFA
{
    // Represents a Deterministic Finite Automata.
    public class DFA<TAlphabet>
    {
        // States
        public HashSet<string> Q { get; set; }

        // Alphabet
        public HashSet<TAlphabet> Σ { get; set; }

        // Transition Function
        public Dictionary<(string, TAlphabet), string> δ { get; set; }

        // Initial State
        public string q0 { get; set; }

        // Final States
        public HashSet<string> F { get; set; }

        // Checks that the parameters of the DFA are set correctly.
        public void Assertδ()
        {
            Debug.Assert(this.Q.Count * this.Σ.Count == this.δ.Count);
            Debug.Assert(this.Q.Contains(this.q0));

            foreach (var q in this.Q)
                foreach (var a in this.Σ)
                    Debug.Assert(this.Q.Contains(this.δ[(q, a)]));
        }

        // Reads the given string and returns true if it 
        // it is accepted by the language of this DFA, and
        // false otherwise.
        public bool Read(IEnumerable<TAlphabet> str)
        {
            this.Assertδ();
            string q = this.q0;

            foreach (var s in str)
                q = this.δ[(q, s)];

            return this.F.Contains(q);
        }
    }
}
