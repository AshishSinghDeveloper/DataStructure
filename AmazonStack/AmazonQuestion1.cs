using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AmazonStack
{
    public class AmazonQuestion1
    {
        public int numberAmazonGoStores(int rows, int column, int[,] grid)
        {
            var sizes = new List<int>();
            bool[,] visited = new bool[rows, column];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (grid[i, j] == 0)
                        continue;
                    sizes = TraverseNode(i, j, visited, grid, sizes);
                }
            }
            return sizes.Count;

        }
        private List<int> TraverseNode(int i, int j, bool[,] visited, int[,] grid, List<int> sizes)
        {
            int currentRiverSize = 0;
            var nodesToExplore = new List<Tuple<int, int>>();
            var node = Tuple.Create(i, j);
            nodesToExplore.Add(node);
            while (nodesToExplore.Any()) //Returns true if list is not empty.
            {
                var currentNode = nodesToExplore.Last();
                nodesToExplore.RemoveAt(nodesToExplore.Count - 1); //Pop - Remove last element from list;
                i = currentNode.Item1; //similar to currentNode[0];
                j = currentNode.Item2; //similar to currentNode[1];
                if (visited[i, j])
                    continue;
                visited[i, j] = true;
                if (grid[i, j] == 0)
                    continue;
                currentRiverSize += 1;
                List<Tuple<int, int>> unvisitedNeighbors = GetUnVisitedNeighbors(i, j, grid, visited);
                foreach (var neighbor in unvisitedNeighbors)
                {
                    nodesToExplore.Add(neighbor);
                }
            }
            if (currentRiverSize > 0)
            {
                sizes.Add(currentRiverSize);
            }
            return sizes;
        }
        private List<Tuple<int, int>> GetUnVisitedNeighbors(int i, int j, int[,] grid, bool[,] visited)
        {
            var unvisitedNeighbors = new List<Tuple<int, int>>();
            if (i > 0 && !visited[i - 1, j])
            {
                var top = Tuple.Create(i - 1, j);
                unvisitedNeighbors.Add(top);
            }
            if (i < grid.GetLength(0) - 1 && !visited[i + 1, j])
            {
                var right = Tuple.Create(i + 1, j);
                unvisitedNeighbors.Add(right);
            }
            if (j > 0 && visited[i, j - 1])
            {
                var left = Tuple.Create(i, j - 1);
                unvisitedNeighbors.Add(left);
            }
            if (j < grid.GetLength(1) - 1 && !visited[i, j + 1])
            {
                var bottom = Tuple.Create(i, j + 1);
                unvisitedNeighbors.Add(bottom);
            }
            return unvisitedNeighbors;
        }
    }
}
