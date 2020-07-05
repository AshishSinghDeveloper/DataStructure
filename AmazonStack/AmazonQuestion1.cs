using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Quesion: River Sizes (from Algo EXPERT)
//You're given a two-dimensional array (a matrix) of potentially unequal height and width containing only o s and 1 s.
//A Each 0 represents land, and each 1 represents part of a river.
//A river consists 1 s that are either horizontally or vertically adjacent (but not diagonally adjacent).
//The number of adjacent 1 s forming a river determine its size.

//Write a function that returns an array of the sizes of all rivers represented in the input matrix.
//The sizes don't need to be in any particular order.

//Sample Input
//matrix = [
//(1, 0, 0, 1, 0),
//[1, 0, 1, 0, 0],
//[0, 0, 1, 0, 1),
//[1, 0, 1, 0, 1).
//[1, 0, 1, 1, 0],

//Sample Input
//[1,2,2,2,5] //the numbers could be ordered differently.

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
