using System.Collections.Generic;

namespace LeetCode.Arrays.Extras;

public class AdjacentIncreasingSubarraysDetection
{
    public bool Solution(IList<int> nums, int k) {
        
        var subarraysSet = new Dictionary<int, IList<int>>();
        var a = 0;
        
        subarraysSet[a] = new List<int>{nums[0]};
        
        
        for(var i = 1; i < nums.Count; i++)
        {
            if(nums[i] <= nums[i-1])
            {
                a = i;
                subarraysSet[i] = new List<int>{nums[i]};
            }
            else
            {
                subarraysSet[a].Add(nums[i]);
            }
        }

        foreach (var (startOfSubarray, subArray) in subarraysSet)
        {
            a = startOfSubarray;
            var b = a + k;
            if(subarraysSet.TryGetValue(b, out var secondSubArray) && subArray.Count == k && secondSubArray.Count == k) { return true;}
            if(subArray.Count >= 2*k) { return true; }
        }
        return false;
    }
}