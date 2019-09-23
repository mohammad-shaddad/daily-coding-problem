using System;
using System.Collections.Generic;

namespace TheMosh.Dcp._082819
{
    public class HitCounter
    {
        private List<long> hits = new List<long>();

        public void Record(long timestamp)
        {
            hits.Add(timestamp);
            hits.Sort();
        }

        public long Total()
        {
            return hits.Count;
        }

        public long Range(long lower, long upper)
        {
            var indexOfLower = FindOrNearestUpper(lower);

            var indexOfUpper = FindOrNearestLower(upper);

            return (indexOfUpper - indexOfLower + 1);
        }

        private int FindOrNearestLower(long timestamp,
                                     int startIndex = 0,
                                     int direction = 1)
        {
            int nearestIndex;

            if (hits[startIndex] == timestamp)
            {
                nearestIndex = startIndex;
            }
            else if (hits[startIndex] > timestamp)
            {
                if (startIndex == 0)
                {
                    nearestIndex = startIndex;
                }
                else
                {
                    int nextIndex = GetNextIndex(startIndex, -1);
                    nearestIndex = FindOrNearestLower(timestamp, nextIndex, -1);
                }
            }
            else
            {
                if (startIndex == this.Total() - 1)
                {
                    nearestIndex = startIndex;
                }
                else
                {
                    if (hits[startIndex + 1] > timestamp)
                    {
                        nearestIndex = startIndex;
                    }
                    else
                    {
                        int nextIndex = GetNextIndex(startIndex, 1);
                        nearestIndex = FindOrNearestLower(timestamp, nextIndex, 1);
                    }
                }
            }
            return nearestIndex;
        }

        private int FindOrNearestUpper(long timestamp,
                                     int startIndex = 0,
                                     int direction = 1)
        {
            int nearestIndex;

            if (hits[startIndex] == timestamp)
            {
                nearestIndex = startIndex;
            }
            else if (hits[startIndex] > timestamp)
            {
                if (startIndex == 0)
                {
                    nearestIndex = startIndex;
                }
                else
                {
                    if (hits[startIndex - 1] < timestamp)
                    {
                        nearestIndex = startIndex;
                    }
                    else
                    {
                        int nextIndex = GetNextIndex(startIndex, -1);
                        nearestIndex = FindOrNearestUpper(timestamp, nextIndex, -1);
                    }
                }
            }
            else
            {
                if (startIndex == this.Total() - 1)
                {
                    nearestIndex = startIndex;
                }
                else
                {
                    int nextIndex = GetNextIndex(startIndex, 1);
                    nearestIndex = FindOrNearestUpper(timestamp, nextIndex, 1);
                }
            }
            return nearestIndex;
        }

        private int GetNextIndex(int currentIndex, int direction)
        {
            if(direction == 1)
            {
                return ((hits.Count - currentIndex) / 2) + currentIndex;
            }
            else
            {
                return (currentIndex - 0) /2;
            }
        }
    }
}