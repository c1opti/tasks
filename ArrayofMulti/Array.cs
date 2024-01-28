using System;

public partial class Program
{
    public static int[] ArrayOfMultiples(int num, int length)
    {
        int[] result = new int[length];
        for (int i = 0; i < length; i++)
        {
            result[i] = num + (num * i);
        }
        return result;
    }
}
/*Create a function that takes two numbers as arguments (num, length) and returns an array of multiples of num until the array length reaches length.

Examples
ArrayOfMultiples(7, 5) ➞ [7, 14, 21, 28, 35]

ArrayOfMultiples(12, 10) ➞ [12, 24, 36, 48, 60, 72, 84, 96, 108, 120]

ArrayOfMultiples(17, 6) ➞ [17, 34, 51, 68, 85, 102]*/