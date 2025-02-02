namespace LeetCode.TwoPointers.Extras;

public class SquaresOfSortedArray
{
    public int[] Solutions(int[] nums)
    {
        var l = 0;
        var r = nums.Length - 1;
        var sol = new int[nums.Length];

        for (var i = 0; i < nums.Length; i++)
        {
            nums[i] *= nums[i];
        }
            
        while (l <= r)
        {
            var lValue = nums[l];
            var rValue = nums[r];

            if (lValue > rValue)
            {
                sol[r - l] = lValue;
                l++;
            }
            else
            {
                sol[r - l] = rValue;
                r--;
            }
        }

        return sol;

    }    
}
