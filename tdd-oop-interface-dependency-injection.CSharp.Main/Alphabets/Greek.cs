using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_interface_dependency_injection.CSharp.Main.Alphabets
{
    public class Greek : ILanguage
    {
        public Dictionary<char, int> getLetterScores()
        {
            Dictionary<Char, int> words = new Dictionary<Char, int>();
            words.Add('α', 1);
            words.Add('ε', 1);
            words.Add('ι', 1);
            words.Add('ο', 1);
            words.Add('φ', 1);
            words.Add('ξ', 1);
            words.Add('β', 2);
            words.Add('δ', 2);
            words.Add('π', 2);
            words.Add('γ', 3);
            words.Add('η', 3);
            words.Add('ν', 3);
            words.Add('τ', 3);
            words.Add('ζ', 4);
            words.Add('κ', 4);
            words.Add('ρ', 4);
            words.Add('ψ', 4);
            words.Add('λ', 4);
            words.Add('θ', 5);
            words.Add('χ', 5);
            words.Add('μ', 8);
            words.Add('σ', 8);
            words.Add('υ', 10);
            words.Add('ω', 10);
            return words;
        }
    }
}
