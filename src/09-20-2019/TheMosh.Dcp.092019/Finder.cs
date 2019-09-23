using System;

namespace TheMosh.Dcp._092019
{
    public class Finder
    {
        public static double Find(double n)
        {
            double level = 1;

            double nSquareRoot = Math.Floor(Math.Sqrt(Convert.ToDouble(n)));

            if(Math.Pow(nSquareRoot, 2) == n)
            {
                return level;
            }
            else
            {
                double lowest = -1;

                for(double i = nSquareRoot; i > 0; i--)
                {
                    double iSquared = Math.Pow(i, 2);

                    double iLevel = 1 + Find(n - iSquared);

                    if(lowest == -1 || iLevel < lowest)
                    {
                        lowest = iLevel;
                    }
                }

                return lowest;
            }
        }
    }
}
