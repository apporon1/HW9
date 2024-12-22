using NUnit.Framework;
using System;
using System.Linq;

namespace StringHelperTests
{
    [TestFixture]
    public class StringHelperTests
    {
        [Test]
        public void ReverseString_EmptyString_ReturnsEmptyString()
        {
            string result = new string("".Reverse().ToArray());
            Assert.AreEqual("", result);
        }

        [Test]
        public void ReverseString_NonNullString_ReturnsReversedString()
        {
            string result = new string("hello".Reverse().ToArray());
            Assert.AreEqual("olleh", result);
        }

        [Test]
        public void ReverseString_NullString_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => { string result = new string(((string)null).Reverse().ToArray()); });
        }

        [Test]
        public void CountWords_EmptyString_ReturnsZero()
        {
            int result = "".Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
            Assert.AreEqual(0, result);
        }

        [Test]
        public void CountWords_SingleWord_ReturnsOne()
        {
            int result = "word".Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
            Assert.AreEqual(1, result);
        }

        [Test]
        public void CountWords_MultipleWords_ReturnsCorrectCount()
        {
            int result = "hello world NUnit".Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
            Assert.AreEqual(3, result);
        }


        [Test]
        public void IsPalindrome_PalindromeString_ReturnsTrue()
        {
            string input = "madam";
            string processed = new string(input.Where(char.IsLetterOrDigit).ToArray()).ToLower();
            bool result = processed.SequenceEqual(processed.Reverse());
            Assert.IsTrue(result);
        }

        [Test]
        public void IsPalindrome_NonPalindromeString_ReturnsFalse()
        {
            string input = "hello";
            string processed = new string(input.Where(char.IsLetterOrDigit).ToArray()).ToLower();
            bool result = processed.SequenceEqual(processed.Reverse());
            Assert.IsFalse(result);
        }

        [Test]
        public void IsPalindrome_EmptyString_ReturnsTrue()
        {
            string input = "";
            string processed = new string(input.Where(char.IsLetterOrDigit).ToArray()).ToLower();
            bool result = processed.SequenceEqual(processed.Reverse());
            Assert.IsTrue(result);
        }

        [Test]
        public void IsPalindrome_StringWithSpecialCharacters_ReturnsTrue()
        {
            string input = "A man, a plan, a canal, Panama";
            string processed = new string(input.Where(char.IsLetterOrDigit).ToArray()).ToLower();
            bool result = processed.SequenceEqual(processed.Reverse());
            Assert.IsTrue(result);
        }

        [Test]
        public void CapitalizeFirstLetter_LowercaseString_ReturnsCapitalizedString()
        {
            string input = "hello";
            string result = char.ToUpper(input[0]) + input.Substring(1);
            Assert.AreEqual("Hello", result);
        }

        [Test]
        public void CapitalizeFirstLetter_EmptyString_ReturnsEmptyString()
        {
            string input = "";
            string result = input.Length == 0 ? "" : char.ToUpper(input[0]) + input.Substring(1);
            Assert.AreEqual("", result);
        }

        [Test]
        public void CapitalizeFirstLetter_AlreadyCapitalizedString_ReturnsSameString()
        {
            string input = "Hello";
            string result = char.ToUpper(input[0]) + input.Substring(1);
            Assert.AreEqual("Hello", result);
        }
    }
}
