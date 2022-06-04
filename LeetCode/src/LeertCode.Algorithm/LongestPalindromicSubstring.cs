namespace LeertCode.Algorithm
{
    public class LongestPalindromicSubstring
    {
        public string LongestPalindrome(string s)
        {
            string longest = string.Empty;
            for (int i = 0; i < s.Length; i++)
            {
                string odd = Substring(s, i, i);
                string even = Substring(s, i, i + 1);
                string currentlongest = odd.Length > even.Length ? odd : even;
                longest = currentlongest.Length > longest.Length ? currentlongest : longest;
            }

            return longest;
        }

        private string Substring(string s, int i, int j)
        {
            bool isPalindrome = false;
            while (i >= 0 && j < s.Length && s[i] == s[j])
            {
                if (!isPalindrome)
                {
                    isPalindrome = true;
                }

                i--; 
                j++;
            }
            if (!isPalindrome)
            {
                return "";
            }

            int length = j - i - 1;
            return s.Substring(i + 1, length);
        }
    }
}