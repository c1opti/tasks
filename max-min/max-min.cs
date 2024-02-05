using System;

public static class maxmin
{
    public static string HighAndLow(string numbers)
    {
        int[] numbersarray = Array.ConvertAll(numbers.Split(' '), int.Parse);
        int indexcount = 0;
        int indexcount_two = 0;
        for (int i = 0; i < numbersarray.Length; i++)
        {
            if (numbersarray[indexcount] < numbersarray[i])
            {
                indexcount = i;
            }
        }
        for (int z = 0; z < numbersarray.Length; z++)
        {
            if (numbersarray[indexcount_two] > numbersarray[z])
            {
                indexcount_two = z;
            }
        }
        return String.Format("{0} {1}", numbersarray[indexcount], numbersarray[indexcount_two]);
    }
}