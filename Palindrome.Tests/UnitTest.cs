namespace Palindrome.Tests
{
    public class UnitTest
    {
        [Theory]
        [InlineData("kayak")]
        [InlineData("noon")]
        [InlineData("Racecar")]
        [InlineData("A man, a plan, a canal, Panama!")]
        public void TestPalindromes(string word)
        {
            Assert.True(WordChecking.IsItAPalindrome(word));
        }
        [Theory]
        [InlineData("another")]
        [InlineData("baobab")]
        [InlineData("Falafel")]
        [InlineData("Hey, how are you?")]
        public void TestNotPalindromes(string word)
        {
            Assert.False(WordChecking.IsItAPalindrome(word));
        }
    }
}