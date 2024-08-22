using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_interface_dependency_injection.CSharp.Main.Alphabets
{
    public class Russian : ILanguage
    {
        public Dictionary<char, int> getLetterScores()
        {
            Dictionary<Char, int> words = new Dictionary<Char, int>();
            words.Add('а', 1);
            words.Add('б', 1);
            words.Add('в', 1);
            words.Add('г', 1);
            words.Add('д', 1);
            words.Add('е', 2);
            words.Add('ё', 2);
            words.Add('ж', 2);
            words.Add('з', 2);
            words.Add('и', 2);
            words.Add('й', 3);
            words.Add('к', 3);
            words.Add('л', 3);
            words.Add('м', 3);
            words.Add('н', 3);
            words.Add('о', 4);
            words.Add('п', 4);
            words.Add('р', 4);
            words.Add('с', 4);
            words.Add('т', 4);
            words.Add('у', 4);
            words.Add('ф', 4);
            words.Add('х', 5);
            words.Add('ц', 5);
            words.Add('ч', 5);
            words.Add('ш', 5);
            words.Add('щ', 8);
            words.Add('ъ', 8);
            words.Add('ы', 8);
            words.Add('ь', 10);
            words.Add('э', 10);
            words.Add('ю', 10);
            return words;
        }
    }
}
