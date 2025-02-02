namespace LeetCode.TwoPointers.Neetcode150;

public class ValidPalindrome2
{
    public bool Solution(string s) {
        var (result, lastLeft, lastRight) = CheckForPalindromeBetween(0, s.Length - 1);

        if (result) return true;
        
        return  CheckForPalindromeBetween(lastLeft + 1, lastRight).Item1 ||  CheckForPalindromeBetween(lastLeft, lastRight - 1).Item1;

        (bool, int, int) CheckForPalindromeBetween(int left, int right)
        {
            while (left <= right)
            {
                if (s[left] == s[right])
                {
                    left++;
                    right--;
                    continue;
                }

                return (false, left, right);
            }

            return (true, left, right);
        }
    }    
}
