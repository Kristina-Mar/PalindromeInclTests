using System.Text.RegularExpressions;

namespace Palindrome
{
    public class WordChecking
    {
        static void Main(string[] args)
        {
            string word = "madam";
            Console.WriteLine($"Is {word} a palindrome? {IsItAPalindrome(word)}");
            word = "noon";
            Console.WriteLine($"Is {word} a palindrome? {IsItAPalindrome(word)}");
            word = "falafel";
            Console.WriteLine($"Is {word} a palindrome? {IsItAPalindrome(word)}");
            string phrase = "How are you?";
            Console.WriteLine($"Is {phrase} a palindrome? {IsItAPalindrome(phrase)}");
            phrase = "A man, a plan, a canal, Panama!";
            Console.WriteLine($"Is {phrase} a palindrome? {IsItAPalindrome(phrase)}");
        }
        public static bool IsItAPalindrome(string text)
        {
            // The string is converted to lowercase and only letters and numbers are left.
            // This way, the method is able to check phrases/sentences as well.
            text = Regex.Replace(text, "[^A-Za-z0-9]", "").ToLower();
            if (text.Length <= 1)
            {
                return true;
            }
            if (text.Substring(0, 1) != text.Substring(text.Length - 1))
            {
                return false;
            }
            return  IsItAPalindrome(text.Substring(1, text.Length - 2));
        }
    }
}
