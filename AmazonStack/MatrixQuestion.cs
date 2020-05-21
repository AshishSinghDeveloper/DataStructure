using System;
using System.Collections;

namespace AmazonStack
{
    public class MatrixQuestion
    {
        public int[] RiverSize(int[,] matrix)
        {
            int[] sizes = new int[0];
            int rowLen = matrix.GetLength(0);
            int colLen = matrix.GetLength(1);
            bool[,] visited = new bool[rowLen, colLen];
            for (int i =0; i < rowLen; i++)
            {
                for (int j = 0; j < colLen; j++)
                {
                    if (matrix[i,j] == 0)
                    {
                        continue;
                    }
                    //sizes = TraverseNode(i, j, visited, matrix);
                }
            }
            return sizes;

        }

        //private int[] TraverseNode(int i, int j, bool[,] visited, int[,] matrix)
        //{
        //    int currentRiverSize = 0;
        //    Stack nodesToExplore = new Stack();
        //    nodesToExplore.Push(matrix[i, j]);
        //    while (nodesToExplore.Count > 0)
        //    {
        //        int[,] currentNode 
        //    }


        //}
    }
}
