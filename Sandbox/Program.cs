using LeetCode.Arrays.Extras;

namespace Sandbox;

public class Program
{
    static void Main(string[] args)
    {
        var iters = 0;
        var testObj = new AdjacentIncreasingSubarraysDetection();
        var param = new[] {2,5,7,8,9,2,3,4,3,1};
        
        Console.Out.WriteLine(MeasureExecutionTime.MeasureFor(() => testObj.Solution(param, 3), iters, out var timeOne));
    }
}