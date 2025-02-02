using System.Collections.Generic;
using NUnit.Framework;
using LeetCode.TwoPointers.Extras;

namespace TestLeetCode.TwoPointers.Neetcode150;

public class TestMergeSortedArray
{
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData((int[]) [1, 2, 3, 0, 0, 0], 3, (int[]) [2, 5, 6], 3)
            .Returns((int[]) [1, 2, 2, 3, 5, 6])
            .SetName("Example case 1: Merge [1, 2, 3, 0, 0, 0] and [2, 5, 6]");
        yield return new TestCaseData((int[]) [1], 1, (int[]) [], 0)
            .Returns((int[]) [1])
            .SetName("Example case 2: Merge [1] and []");
        yield return new TestCaseData((int[]) [0], 0, (int[]) [1], 1)
            .Returns((int[]) [1])
            .SetName("Example case 3: Merge [0] and [1]");
        yield return new TestCaseData((int[]) [2, 0], 1, (int[]) [1], 1)
            .Returns((int[]) [1, 2])
            .SetName("Example case 4: Merge [2, 0] and [1]");
        yield return new TestCaseData((int[]) [2, 0], 1, (int[]) [3], 1)
            .Returns((int[]) [2, 3])
            .SetName("Example case 5: Merge [2, 0] and [3]");
        yield return new TestCaseData((int[]) [0, 0, 0, 0, 0], 5, (int[]) [1, 2, 3, 4, 5], 5)
            .Returns((int[]) [1, 2, 3, 4, 5])
            .SetName("Example case 6: Merge [] and [1, 2, 3, 4, 5]");
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public int[] TestSolution(int[] nums1, int m, int[] nums2, int n)
    {
        var testObject = new MergeSortedArray();
        testObject.Solution(nums1, m, nums2, n);
        return nums1;
    }
}