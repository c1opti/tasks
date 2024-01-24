using System;

namespace ha3ck4r_sp3ik
{
    class h3ckerspe3k
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            Console.WriteLine(Algo(word));
        }

        static string Algo(string word)
        {
            word = word.Replace('a', '4');
            word = word.Replace('e', '3');
            word = word.Replace('i', '1');
            word = word.Replace('s', '5');
            return word;
        }
    }
}
