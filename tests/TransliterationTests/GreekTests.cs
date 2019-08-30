using NUnit.Framework;
using SharpTransliterator;
using SharpTransliterator.Languages;

namespace TransliterationTests
{
    public class GreekTests
    { 
        [Test]
        public void GreekToRomanTest()
        {
            Assert.AreEqual("kalimera", "καλημερα".TransliterateToRoman("el-GR")); 
            Assert.AreEqual("kalimera", "καλημέρα".TransliterateToRoman("el-GR"));
            Assert.AreEqual("Ti kaneis mpampa?", "Τί κάνεις μπαμπά;".TransliterateToRoman("el-GR"));
            Assert.AreEqual("Ena to chelidoni kai i anoixi akrivi opote kalytera cheimerinoi kolymvites to ximeroma!", 
                "Ένα το χελιδόνι και η άνοιξη ακριβή οπότε καλύτερα χειμερινοί κολυμβητές το ξημέρωμα!".TransliterateToRoman("el-GR"));
            Assert.AreEqual(@"~!@#$%^&*()_+}{|\/<>,\", @"~!@#$%^&*()_+}{|\/<>,\".TransliterateToRoman("el-GR"));
        }

        [Test]
        public void GreekToRomanTestWithTable()
        {
            Assert.AreEqual("kalimera", "καλημερα".Transliterate(Languages.GreekToRomanTransliterationTable));
            Assert.AreEqual("kalimera", "καλημέρα".Transliterate(Languages.GreekToRomanTransliterationTable));
            Assert.AreEqual("Ti kaneis mpampa?", "Τί κάνεις μπαμπά;".Transliterate(Languages.GreekToRomanTransliterationTable));
            Assert.AreEqual("Ena to chelidoni kai i anoixi akrivi opote kalytera cheimerinoi kolymvites to ximeroma!",
                "Ένα το χελιδόνι και η άνοιξη ακριβή οπότε καλύτερα χειμερινοί κολυμβητές το ξημέρωμα!".TransliterateToRoman("el-GR"));
            Assert.AreEqual(@"~!@#$%^&*()_+}{|\/<>,\", @"~!@#$%^&*()_+}{|\/<>,\".Transliterate(Languages.GreekToRomanTransliterationTable));
        }

        [Test]
        public void RemoveIntonationTest()
        {
            Assert.AreEqual("kalimera", "καλημερα".RemoveIntonation().TransliterateToRoman("el-GR"));
            Assert.AreEqual("καλημερα", "καλημέρα".RemoveIntonation());
            Assert.AreEqual("ΚαλHμΞερα laλαλαλα ενα τι", "ΚάλHμΞέρα laλάλάλά ένα τΐ".RemoveIntonation());
            Assert.AreEqual("Ena to chelidoni kai i anoixi akrivi opote kalytera cheimerinoi kolymvites to ximeroma!",
                "Ένα το χελιδόνι και η άνοιξη ακριβή οπότε καλύτερα χειμερινοί κολυμβητές το ξημέρωμα!".TransliterateToRoman("el-GR"));
            Assert.AreEqual(@"~!@#$%^&*()_+}{|\/<>,\", @"~!@#$%^&*()_+}{|\/<>,\".TransliterateToRoman("el-GR"));
        }
    }
}