using NUnit.Framework;
using Trivial.Utility;

namespace Tests
{
    [TestFixture]
    public class GrammarTest
    {
        [SetUp]
        public void Setup() { }

        [TestCase(-1)]
        [TestCase(1)]
        public void Test_Pluralize_OneCount_SingularWord(int value)
        {
            string word = "Error";
            string singularWord = Grammar.Pluralize(value, word);
            Assert.IsTrue("Error".Equals(singularWord), $"{value} count must not return plural word: {singularWord}");
        }

        [Test]
        public void Test_Pluralize_PluralInput_SingularWord()
        {
            string word = "Error";
            string pluralInput = "Works!";
            string pluralWordOutput = Grammar.Pluralize(2, word, pluralInput);
            Assert.IsTrue(pluralInput.Equals(pluralWordOutput), $" Plural word output is not equal to plural input word: {pluralInput}");
        }

        [TestCase("one")]
        [TestCase("One")]
        public void Test_Pluralize_OneCountString_SingularWord(string value)
        {
            string word = "Error";
            string singularWord = Grammar.Pluralize(value, word);
            Assert.IsTrue("Error".Equals(singularWord), $"{value} count must not return plural word: {singularWord}");
        }

        [TestCase(-2)]
        [TestCase(0)]
        [TestCase(3)]
        public void Test_Pluralize_NotOneCount_PluralWord(int value)
        {
            string word = "Error";
            string pluralWord = Grammar.Pluralize(value, word);
            Assert.IsTrue("Errors" == pluralWord, "Plural word must be return from multiple count");
        }
    }
}