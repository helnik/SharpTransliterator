# SharpTransliterator
Simple Transliterator in C#. 

1. Can Transliterate a string based on a transliteration table. 

Examples: 

```
 Assert.AreEqual("kalimera", "καλημερα".Transliterate(Languages.GreekToRomanTransliterationTable));
 Assert.AreEqual("kalimera", "καλημέρα".Transliterate(Languages.GreekToRomanTransliterationTable));
 Assert.AreEqual("Ti kaneis mpampa?", "Τί κάνεις μπαμπά;".Transliterate(Languages.GreekToRomanTransliterationTable));
 Assert.AreEqual("Ena to chelidoni kai i anoixi akrivi opote kalytera cheimerinoi kolymvites to ximeroma!",
     "Ένα το χελιδόνι και η άνοιξη ακριβή οπότε καλύτερα χειμερινοί κολυμβητές το ξημέρωμα!".TransliterateToRoman("el-GR"));
 Assert.AreEqual(@"~!@#$%^&*()_+}{|\/<>,\", @"~!@#$%^&*()_+}{|\/<>,\".Transliterate(Languages.GreekToRomanTransliterationTable));
```

2. Can transliterate a string to Roman from built-in transliteration tables based on the given culture, or from the CurrentCulture.

Built-in transliteration tables:
-Greek

Examples:

```
Assert.AreEqual("kalimera", "καλημερα".TransliterateToRoman("el-GR"));
OR
Assert.AreEqual("kalimera", "καλημερα".TransliterateToRoman());
```

3. Can remove intonation.

Examples:

```
Assert.AreEqual("kalimera", "καλημερα".RemoveIntonation().TransliterateToRoman("el-GR"));
Assert.AreEqual("καλημερα", "καλημέρα".RemoveIntonation());
Assert.AreEqual("ΚαλHμΞερα laλαλαλα ενα τι", "ΚάλHμΞέρα laλάλάλά ένα τΐ".RemoveIntonation());
```
