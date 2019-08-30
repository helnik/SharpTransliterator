using System.Collections.Generic;

namespace SharpTransliterator
{
    public class TransliterationTable
    {
        /// <summary>
        /// The Culture full name. E.g: en-US
        /// </summary>
        public string CultureName { get; set; }

        /// <summary>
        /// Transliteration Table
        /// </summary>
        public Dictionary<string, string> Table { get; set; }
    }
}
