using LeertCode.Algorithm;

namespace LeetCode.Algorithm.Test
{
    public class LongestPalindromicSubstringTest
    {
        private LongestPalindromicSubstring _algorithm;

        public LongestPalindromicSubstringTest()
        {
            _algorithm = new LongestPalindromicSubstring();
        }


        [Theory]
        [InlineData("babad", "bab")]
        [InlineData("cbbd", "bb")]
        public void LongestPalindromeTest(string input, string output)
        {
            var result = _algorithm.LongestPalindrome(input);

            Assert.Equal(output, result);
        }
    }
}