using System;
using System.Globalization;
using System.Text;
using SharpTransliterator.Languages;

namespace SharpTransliterator
{
    public static class SharpTransliterator
    {
        /// <summary>
        /// Transliterate a string from CurrentCulture to Roman
        /// </summary>
        /// <param name="sValue"></param>
        /// <returns></returns>
        public static string TransliterateToRoman(this string sValue)
        {
            sValue.EnsureHasValue();
            var currentCulture = CultureInfo.CurrentCulture.Name;

            return TryGetTableAndTransliterate(sValue, currentCulture);
        }

        /// <summary>
        /// Transliterate a string from the provided culture to Roman 
        /// </summary>
        /// <param name="sValue">The string to transliterate</param>
        /// <param name="culture">Culture to transliterate from</param>
        /// <returns></returns>
        public static string TransliterateToRoman(this string sValue, string culture)
        {
            sValue.EnsureHasValue();
            culture.EnsureHasValue();

            return TryGetTableAndTransliterate(sValue, culture);
        }

        /// <summary>
        ///  Transliterate a string based on a given transliteration table
        /// </summary>
        /// <param name="sValue"></param>
        /// <param name="transliterationTable"></param>
        /// <returns></returns>
        public static string Transliterate(this string sValue, TransliterationTable transliterationTable)
        {
            sValue.EnsureHasValue();
            if (transliterationTable?.Table == null)
            {
                throw new ArgumentNullException(nameof(transliterationTable));
            }

            return TransliterateFromTable(sValue, transliterationTable);
        }
        
        private static string TryGetTableAndTransliterate(string sValue, string currentCulture)
        {
            if (ConstantTransliterationTables.ToRomanTransliterationTables.TryGetValue(currentCulture, out var tranTable))
            {
                return TransliterateFromTable(sValue, tranTable);
            }

            throw new NotSupportedException(
                $"{currentCulture} is not pre defined. Please provide the corresponding transliteration table");
        }

        private static string TransliterateFromTable(string sValue, TransliterationTable tranTable)
        {
            var sb = new StringBuilder();
            foreach (char c in sValue)
            {
                if (char.IsDigit(c))
                {
                    sb.Append(c.ToString());
                }
                else
                {
                    sb.Append(tranTable.Table.TryGetValue(c.ToString(), out string translited) ? translited : "?");
                }
            }

            return sb.ToString();
        }

        /// <summary>
        /// Removes intonation on a given string
        /// </summary>
        /// <param name="sValue"></param>
        /// <returns></returns>
        public static string RemoveIntonation(this string sValue)
        {
            sValue.EnsureHasValue();
            string normalized = sValue.Normalize(NormalizationForm.FormD);
            var sb = new StringBuilder();
            foreach (char c in normalized)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    sb.Append(c);
                }
            }

            return sb.ToString().Normalize(NormalizationForm.FormC);
        }
    }
}
