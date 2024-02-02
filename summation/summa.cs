namespace typesorsmth
{
    public static class Kata
    {
        public static int summation(int num)
        {
            int answer = 0;
            for (int i = 0; i <= num; i++)
            {
                answer = answer + i;
            }
            return answer;
        }
    }
}
