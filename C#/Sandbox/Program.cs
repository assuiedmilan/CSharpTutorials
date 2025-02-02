using System.Collections;
using LeetCode.Arrays.Extras;
using LeetCode.TwoPointers.Extras;

// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnusedMember.Local
#pragma warning disable CS0219 // Variable is assigned but its value is never used

namespace Sandbox;

public class Program
{
    static void Main()
    {
        var testObj = new MergeSortedArray();
        var firstArg = new[] { 0, 0, 0 ,0 ,0 };
        var secondArg = new[] { 1, 2, 3, 4, 5 };

        testObj.Solution(firstArg, 5, secondArg, 5);
        
        Console.WriteLine(firstArg);
    }
    
    static void Print(object result, object expected)
    {
        if(expected is ICollection expectedCollection)
        {
            var resultCollection = (ICollection) result;
            Console.WriteLine($"Results:");
            foreach (var pair in expectedCollection.Cast<object>().Zip(resultCollection.Cast<object>(), (e, r) => new { Expected = e, Result = r }))
            {
                Console.WriteLine($"Expected: {pair.Expected}, Result: {pair.Result}");
            }
            return;
        }
        
        Console.WriteLine($"Expected: {result}, Result: {expected}");
    }
}