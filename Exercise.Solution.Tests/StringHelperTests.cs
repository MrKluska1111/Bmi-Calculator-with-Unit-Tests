using FluentAssertions;

namespace Exercise.Solution.Tests
{
    public class StringHelperTests
    {
        [Theory]
        [InlineData("ala ma kota", "kota ma ala")]
        [InlineData("To jest testowe zdanie", "zdanie testowe jest To")]
        [InlineData("This test checks reversing words", "words reversing checks test This")]
        public void ReverseWords_ForGivenSentence_ReturnsReversedSentence(string sentence, string expectedResult)
        {
            //act
            var result = StringHelper.ReverseWords(sentence);

            //assert
            result.Should().Be(expectedResult);
        }

        [Theory]
        [InlineData("ala")]
        [InlineData("kajak")]
        [InlineData("pop")]
        public void IsPalindrome_ForPalindromWord_ReturnsTrueValue(string word)
        {
            //act
            bool result = StringHelper.IsPalindrome(word);

            //
            result.Should().Be(true);
        }

        [Theory]
        [InlineData("Ala")]
        [InlineData("Kuba")]
        [InlineData("Test")]
        public void IsPalindrome_ForNonPalindromWord_ReturnsFalseValue(string word)
        {
            //act
            bool result = StringHelper.IsPalindrome(word);

            //assert
            result.Should().Be(false);
        }

    }
}