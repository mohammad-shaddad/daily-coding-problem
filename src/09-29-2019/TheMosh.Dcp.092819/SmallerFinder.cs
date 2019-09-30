using System;

namespace TheMosh.Dcp._092819
{
    public class SmallerFinder
    {
        public static int[] Find(int[] array)
        {
            var smaller = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                int smallers = 0;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[i])
                    {
                        ++smallers;
                    }
                }

                smaller[i] = smallers;
            }
            return smaller;
        }
    }
}
