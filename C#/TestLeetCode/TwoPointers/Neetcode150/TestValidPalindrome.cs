using System.Collections.Generic;
using LeetCode.TwoPointers.Neetcode150;
using NUnit.Framework;

namespace TestLeetCode.TwoPointers.Neetcode150;

public class TestValidPalindrome
{
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData("A man, a plan, a canal: Panama").Returns(true).SetName("Example case 1: Valid palindrome");
        yield return new TestCaseData("race a car").Returns(false).SetName("Example case 2: Not a palindrome");
        yield return new TestCaseData(" ").Returns(true).SetName("Example case 3: Empty string");
        yield return new TestCaseData("0P").Returns(false).SetName("Example case 4: Not a palindrome with non-alphanumeric characters");
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public bool TestSolution(string s)
    {
        var testObject = new ValidPalindrome();
        return testObject.Solution(s);
    }
}
