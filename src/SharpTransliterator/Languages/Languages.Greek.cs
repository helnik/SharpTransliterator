using System.Collections.Generic;

namespace SharpTransliterator.Languages
{
    public partial class Languages
    {
        public static readonly Dictionary<string, string> GreekToRomanTransliterationDictionary =
            new Dictionary<string, string>
            {
                {"Α", "A"}, {"Β", "V"}, {"Γ", "G"}, {"Δ", "D"}, {"Ε", "E"}, {"Ζ", "Z"}, {"Η", "I"}, {"Θ", "Th"}, {"Ι", "I"}, {"Κ", "K"},
                {"Λ", "L"}, {"Μ", "M"}, {"Ν", "N"}, {"Ξ", "X"}, {"Ο", "O"}, {"Π", "P"}, {"Ρ", "R"}, {"Σ", "S"}, {"Τ", "T"}, {"Υ", "Y"},
                {"Φ", "F"}, {"Χ", "Ch"}, {"Ψ", "Ps"}, {"Ω", "O"},
                {"α", "a"}, {"β", "v"}, {"γ", "g"}, {"δ", "d"}, {"ε", "e"}, {"ζ", "z"}, {"η", "i"}, {"θ", "th"}, {"ι", "i"}, {"κ", "k"},
                {"λ", "l"}, {"μ", "m"}, {"ν", "n"}, {"ξ", "x"}, {"ο", "o"}, {"π", "p"}, {"ρ", "r"}, {"σ", "s"},  {"ς", "s"}, {"τ", "t"},
                { "υ", "y"}, {"φ", "f"}, {"χ", "ch"}, {"ψ", "ps"},{"ω", "o"},
                {"Ά", "A"}, {"Έ", "E"}, {"Ή", "I"}, {"Ί", "I"}, {"Ό", "O"}, {"Ύ", "Y"}, {"Ώ", "O"},
                {"ά", "a"}, {"έ", "e"}, {"ή", "i"}, {"ί", "i"}, {"ό", "o"}, { "ύ", "y"}, {"'ω", "o"},
                { " ", " "}, {";", "?"}, {"·", ";"}, {"’", "'"},
                {"~", "~"}, {"!", "!"}, {"@", "@"}, {"#", "#"}, {"$", "$"}, {"%", "%"}, {"^", "^"}, {"&", "&"}, {"*", "*"}, {"(", "("}, {")", ")"},
                {"-", "-"}, {"_", "_"}, {"+", "+"}, {"=", "="}, {"{", "{"}, {"}", "}"}, {"[", "["}, {"]", "]"}, {@"\", @"\"}, {"|", "|"},
                {$"{(char)34}",$"{(char)34}"},
                { ".", "."}, {":", ":"}, {",", ","}, {"<", "<"}, {">", ">"}, {"/", "/"}, {"?", "?"}
            };

        public static readonly TransliterationTable GreekToRomanTransliterationTable = new TransliterationTable
        {
            CultureName = "el-GR",
            Table = GreekToRomanTransliterationDictionary
        };
    }
}
