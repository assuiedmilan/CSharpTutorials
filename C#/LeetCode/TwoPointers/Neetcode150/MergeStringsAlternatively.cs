using System;
using System.Text;

namespace LeetCode.TwoPointers.Neetcode150;

public class MergeStringsAlternatively
{
    public string Solution(string word1, string word2)
    {
        var firstWordIsLonger = word1.Length > word2.Length;
        var stopSize = firstWordIsLonger ? word2.Length : word1.Length;
        var newSize = word1.Length + word2.Length;

        var buffer = new StringBuilder(newSize);

        for (var i = 0; i < stopSize; i++)
        {
            buffer.Append(word1[i]);
            buffer.Append(word2[i]);
        }

        if (firstWordIsLonger)
        {
            for (var i = stopSize; i < word1.Length; i++)
            {
                buffer.Append(word1[i]);
            }
        }
        else
        {
            for (var i = stopSize; i < word2.Length; i++)
            {
                buffer.Append(word2[i]);
            }  
        }

        return buffer.ToString();
    }    
}
 