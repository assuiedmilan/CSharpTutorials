namespace LeetCode.Others;

/* https://leetcode.com/problems/baseball-game/description/ */
public class PrefixCommonArray
{
    public int[] Solution(int[] A, int[] B)
    {
        var ans = new int[A.Length];
        var encountered = new bool[A.Length];
        var prefix = 0;

        for (var i = 0; i < A.Length; i++)
        {
            if (A[i] == B[i])
            {
                prefix += 1;
                ans[i] = prefix;
                continue;
            }

            if (encountered[A[i] - 1])
            {
                prefix += 1;
            }
            else
            {
                encountered[A[i] - 1] = true;
            }

            if (encountered[B[i] - 1])
            {
                prefix += 1;
            }
            else
            {
                encountered[B[i] - 1] = true;
            }
            
            ans[i] = prefix;
        }

        return ans;
    }    
}
