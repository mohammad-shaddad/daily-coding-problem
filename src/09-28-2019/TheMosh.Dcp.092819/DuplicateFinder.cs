using System;

namespace TheMosh.Dcp._092819
{
    public class DuplicateFinder
    {
        public static int FindDuplicate(int[] array)
        {
            int duplicate = -1;

            for (int i = 0; i < array.Length - 1; i++)
            {
                duplicate = array[i];

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] == duplicate)
                    {
                        return duplicate;
                    }
                }
            }

            return duplicate;
        }
    }
}
