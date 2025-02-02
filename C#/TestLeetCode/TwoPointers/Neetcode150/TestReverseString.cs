using System.Collections.Generic;
using LeetCode.TwoPointers.Neetcode150;
using NUnit.Framework;

namespace TestLeetCode.TwoPointers.Neetcode150;

public class TestReverseString
{
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData((char[]) ['h', 'e', 'l', 'l', 'o']).Returns((char[]) ['o', 'l', 'l', 'e', 'h']).SetName("Example case 1: Reverse 'hello'");
        yield return new TestCaseData((char[]) ['H', 'a', 'n', 'n', 'a', 'h']).Returns((char[]) ['h', 'a', 'n', 'n', 'a', 'H']).SetName("Example case 2: Reverse 'Hannah'");
        yield return new TestCaseData((char[]) ['a']).Returns((char[]) ['a']).SetName("Single character");
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public char[] TestSolution(char[] s)
    {
        var testObject = new ReverseString();
        testObject.Solution(s);
        return s;
    }
}
