using System;

namespace TheMosh.Dcp._092019
{
    public class PathFinder
    {
        private int paths = 0;

        public int FindPaths(int[,] matrix)
        {
            WalkToEnd(0, 0, matrix);

            return paths;
        }


        private bool WalkToEnd(int vIndex, int hIndex, int[,] matrix)
        {
            if(hIndex == matrix.GetLength(1) - 1 && vIndex == matrix.GetLength(0) - 1)
            {
                paths++;
                return true;
            }
            else
            {
                if(CanWalkRight(vIndex, hIndex, matrix))
                {
                    WalkToEnd(vIndex, hIndex + 1, matrix);
                }
                if(CanWalkDown(vIndex, hIndex, matrix))
                {
                    WalkToEnd(vIndex + 1, hIndex, matrix);
                }
            }
            return false;
        }

        private bool CanWalkRight(int vIndex, int hIndex, int [,] matrix)
        {
            if(hIndex == matrix.GetLength(1) - 1)
            {
                return false;
            }
            else if(matrix[vIndex, hIndex + 1] == 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool CanWalkDown(int vIndex, int hIndex, int[,] matrix)
        {
            if (vIndex == matrix.GetLength(0) - 1)
            {
                return false;
            }
            else if (matrix[vIndex + 1, hIndex] == 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}