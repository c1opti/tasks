using System.Linq;
namespace tasks
{
    public static class ArraysInversion
    {
        public static int[] InvertValues(int[] input)
        {
            int[] output = new int[input.Length];
            //Code it!
            // ok
            for (int i = 0; i < input.Length; i++)
            {
                output[i] = input[i] - (input[i] * 2);
            }
            return output;
        }
    }
}
/*Given a set of numbers, return the additive inverse of each. Each positive becomes negatives, and the negatives become positives.

invert([1,2,3,4,5]) == [-1,-2,-3,-4,-5]
invert([1,-2,3,-4,5]) == [-1,2,-3,4,-5]
invert([]) == []*/