public static class MultiplySolution
{
    public static int Solution(int value)
    {
        int answer = 0;
        for (int i = 1; i < value; i++)
        {
            if ((i) % 3 == 0 || (i) % 5 == 0)
            {
                answer = answer + i;
            }
        }
        return answer;
    }
}