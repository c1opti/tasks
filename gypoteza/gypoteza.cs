using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(Collatz(n));
    }

    static int Collatz(int n)
    {
        int answer = n;
        int counter = 0;
        while (answer !=1)
        {
            if (answer % 2 == 0)
            {
                answer = answer / 2;
            }
            else
            {
                answer = answer * 3 + 1;
            }
            counter++;
        }
        return counter;
    }
}
