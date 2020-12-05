using System;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        char[] inputCharArray = input.ToCharArray();
        string reverseSolution = "";
        for(var i = inputCharArray.Length - 1; i >= 0; i--)
        {
            reverseSolution += inputCharArray[i];
        }
        return reverseSolution;
    }
}