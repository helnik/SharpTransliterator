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
            Assert.AreEqual("kalimera", "��������".TransliterateToRoman("el-GR")); 
            Assert.AreEqual("kalimera", "��������".TransliterateToRoman("el-GR"));
            Assert.AreEqual("Ti kaneis mpampa?", "�� ������ ������;".TransliterateToRoman("el-GR"));
            Assert.AreEqual("Ena to chelidoni kai i anoixi akrivi opote kalytera cheimerinoi kolymvites to ximeroma!", 
                "��� �� �������� ��� � ������ ������ ����� �������� ���������� ���������� �� ��������!".TransliterateToRoman("el-GR"));
            Assert.AreEqual(@"~!@#$%^&*()_+}{|\/<>,\", @"~!@#$%^&*()_+}{|\/<>,\".TransliterateToRoman("el-GR"));
        }

        [Test]
        public void GreekToRomanTestWithTable()
        {
            Assert.AreEqual("kalimera", "��������".Transliterate(Languages.GreekToRomanTransliterationTable));
            Assert.AreEqual("kalimera", "��������".Transliterate(Languages.GreekToRomanTransliterationTable));
            Assert.AreEqual("Ti kaneis mpampa?", "�� ������ ������;".Transliterate(Languages.GreekToRomanTransliterationTable));
            Assert.AreEqual("Ena to chelidoni kai i anoixi akrivi opote kalytera cheimerinoi kolymvites to ximeroma!",
                "��� �� �������� ��� � ������ ������ ����� �������� ���������� ���������� �� ��������!".TransliterateToRoman("el-GR"));
            Assert.AreEqual(@"~!@#$%^&*()_+}{|\/<>,\", @"~!@#$%^&*()_+}{|\/<>,\".Transliterate(Languages.GreekToRomanTransliterationTable));
        }

        [Test]
        public void RemoveIntonationTest()
        {
            Assert.AreEqual("kalimera", "��������".RemoveIntonation().TransliterateToRoman("el-GR"));
            Assert.AreEqual("��������", "��������".RemoveIntonation());
            Assert.AreEqual("���H����� la������ ��� ��", "���H����� la������ ��� ��".RemoveIntonation());
            Assert.AreEqual("Ena to chelidoni kai i anoixi akrivi opote kalytera cheimerinoi kolymvites to ximeroma!",
                "��� �� �������� ��� � ������ ������ ����� �������� ���������� ���������� �� ��������!".TransliterateToRoman("el-GR"));
            Assert.AreEqual(@"~!@#$%^&*()_+}{|\/<>,\", @"~!@#$%^&*()_+}{|\/<>,\".TransliterateToRoman("el-GR"));
        }
    }
}