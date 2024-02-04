using System;

public class removeNoise
{
    public static string RemoveNoise(string equation)
    {
        string noise = "%$&/#·@|º\'ª";
        foreach (char c in noise)
        {
            equation = equation.Replace(c.ToString(), "");
        }
        return equation;
    }
}