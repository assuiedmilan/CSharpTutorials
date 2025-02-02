namespace LeetCode.TwoPointers.Neetcode150;

//https://leetcode.com/problems/reverse-string/description/
public class ReverseString
{
    public void Solution(char[] s)
    {
        var left = 0;

        while (left < s.Length/2)
        {
            (s[left], s[^(1+left)]) = (s[^(1+left)], s[left]);
            left++;
        }
    }    
}
 