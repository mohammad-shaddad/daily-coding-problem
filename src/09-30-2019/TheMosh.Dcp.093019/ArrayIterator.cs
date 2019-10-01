using System;

namespace TheMosh.Dcp._093019
{
    public class ArrayIterator
    {
        private int[][] arrays;
        private int currentVertical = -1;
        private int currentHorizontal = -1;

        public ArrayIterator(int[][] input)
        {
            arrays = input;
        }

        public int Next()
        {
            if (HasNext())
            {
                int vi = currentVertical, hi = currentHorizontal;

                for (int i = vi == -1 ? 0 : vi; i < arrays.Length; i++)
                {
                    if (arrays[i] == null || arrays[i].Length == 0)
                    {
                        hi = -1;
                        continue;
                    }
                    if (hi + 1 == arrays[i].Length)
                    {
                        hi = -1;
                        continue;
                    }
                    else
                    {
                        currentVertical = i;
                        currentHorizontal = hi+ 1;
                        return arrays[currentVertical][currentHorizontal];
                    }
                }
                return -1;
            }
            else throw new Exception("Reached end of values");
        }

        public bool HasNext()
        {
            if (arrays == null || arrays.Length == 0)
            {
                return false;
            }

            int vi = currentVertical, hi = currentHorizontal;

            for (int i = vi == -1 ? 0 : vi; i < arrays.Length; i++)
            {
                if (arrays[i] == null || arrays[i].Length == 0)
                {
                    hi = -1;
                    continue;
                }
                if (hi + 1 == arrays[i].Length)
                {
                    hi = -1;
                    continue;
                }
                else
                {
                    return true;
                }
            }

            return false;
        }
    }
}
