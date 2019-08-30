using System.Collections.Generic;

namespace SharpTransliterator.Languages
{
    public static class ConstantTransliterationTables
    {  
        public static readonly Dictionary<string, TransliterationTable> ToRomanTransliterationTables =
            new Dictionary<string, TransliterationTable>
            {
                { "el-GR", Languages.GreekToRomanTransliterationTable }
            };
    }
}
