public class Walk
{
    public static bool IsValidWalk(string[] walk)
    {
        if (walk.Length != 10) return false;
        int i = 0;
        int n = 0, s = 0, e = 0, w = 0;
        while (i < walk.Length)
        {
            if (walk[i] == "n") n++;
            else if (walk[i] == "w") w++;
            else if (walk[i] == "s") s++;
            else if (walk[i] == "e") e++;
            i++;
        }
        if (n == s && e == w)
        {
            return true;
        }
        else return false;
    }
}