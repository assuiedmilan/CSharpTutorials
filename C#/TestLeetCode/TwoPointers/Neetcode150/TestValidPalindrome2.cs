using System.Collections.Generic;
using LeetCode.TwoPointers.Neetcode150;
using NUnit.Framework;

namespace TestLeetCode.TwoPointers.Neetcode150;

public class TestValidPalindrome2
{
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData("abca").Returns(true).SetName("Example case 1: Valid palindrome by removing one character");
        yield return new TestCaseData("abc").Returns(false).SetName("Example case 2: Not a palindrome even after removing one character");
        yield return new TestCaseData("deeee").Returns(true).SetName("Example case 3: Valid palindrome by removing one character");
        yield return new TestCaseData("a").Returns(true).SetName("Single character");
        yield return new TestCaseData("").Returns(true).SetName("Empty string");
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public bool TestSolution(string s)
    {
        var testObject = new ValidPalindrome2();
        return testObject.Solution(s);
    }
}
