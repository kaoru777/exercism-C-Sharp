using System;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        char[] firstString = firstStrand.ToCharArray();
        char[] secondString = secondStrand.ToCharArray();

        if (firstString.Length != secondString.Length)
        {
            throw new ArgumentException("Strings have different lengths");
        }

        var counter = 0;
        for (var i = 0; i < firstString.Length; i++)
        {
            if (firstString[i] != secondString[i])
            {
                counter++;
            }
        }
        return counter;
    }
}