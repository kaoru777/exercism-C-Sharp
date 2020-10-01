using System;
using System.Collections.Generic;

public static class NucleotideCount
{


    public static IDictionary<char, int> Count(string sequence)
    {
        IDictionary<char, int> countDict = new Dictionary<char, int>
        {
            ['A'] = 0,
            ['C'] = 0,
            ['G'] = 0,
            ['T'] = 0
        };

        char[] sequenceArray = sequence.ToCharArray();

        for (var i = 0; i < sequenceArray.Length; i++)
        {
            if (!countDict.ContainsKey(sequenceArray[i]))
            {
                throw new ArgumentException("Not found");
            }
            else
            {
                countDict[sequenceArray[i]] = ++countDict[sequenceArray[i]];
            }
        }

        return countDict;
    }
}