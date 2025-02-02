using System.Collections.Generic;
using LeetCode.TwoPointers.Neetcode150;
using NUnit.Framework;

namespace TestLeetCode.TwoPointers.Neetcode150;

public class TestMergeStringsAlternatively
{
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData("abc", "pqr").Returns("apbqcr").SetName("Example case 1: Merge 'abc' and 'pqr'");
        yield return new TestCaseData("ab", "pqrs").Returns("apbqrs").SetName("Example case 2: Merge 'ab' and 'pqrs'");
        yield return new TestCaseData("abcd", "pq").Returns("apbqcd").SetName("Example case 3: Merge 'abcd' and 'pq'");
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public string TestSolution(string word1, string word2)
    {
        var testObject = new MergeStringsAlternatively();
        return testObject.Solution(word1, word2);
    }
}
