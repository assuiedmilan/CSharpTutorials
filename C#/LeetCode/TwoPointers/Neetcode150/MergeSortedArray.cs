namespace LeetCode.TwoPointers.Neetcode150;

public class MergeSortedArray
{
    public void Solution(int[] nums1, int m, int[] nums2, int n)
    {
        var firstArrayPointer = nums1.Length -m - 1;
        var secondArrayPointer = n - 1;
        
        for (var i = nums1.Length - 1; i > -1 && secondArrayPointer > -1; i--)
        {
            if (firstArrayPointer > -1 && nums1[firstArrayPointer] > nums2[secondArrayPointer])
            {
                nums1[i] = nums1[firstArrayPointer];
                firstArrayPointer--;
                continue;
            }

            nums1[i] = nums2[secondArrayPointer];
            secondArrayPointer--;
        }
    }    
}
