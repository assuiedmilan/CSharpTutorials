namespace LeetCode.TwoPointers.Neetcode150;

public class ValidPalindrome
{
    public bool Solution(string s)
    {
        const int zero = '0';
        const int aMin = 'a';
        const int aMaj = 'A';
        
        var l = 0;
        var r = s.Length - 1;

        while (l <= r)
        {
            while (l < s.Length && !IsLetter(s[l])) l++;
            while (r > -1 && !IsLetter(s[r])) r--;
            
            if (l == s.Length || r == -1) return true;
            if (ToLower(s[l]) != ToLower(s[r])) return false;

            l++;
            r--;
        }

        return true;
        
        bool IsLetter(char c) => (zero <= c && c <= zero+9) || (aMin <= c && c <= aMin+25) || (aMaj <= c && c <= aMaj+25);
        char ToLower(char c) => aMaj <= c && c <= aMaj+25 ? (char)(c + 32) : c;
    }
}
