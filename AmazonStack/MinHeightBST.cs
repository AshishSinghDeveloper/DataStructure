using System.Collections.Generic;
//------------------------------------------------------------------------------------------------------------------------------------------------------
//Question: Min Height BST (from AlgoExpert)
//Write a function that takes in a non-empty sorted array of distinct integers, constructs a BST from the integers, and returns the root of the BST.

//The function should minimize the height of the BST.

//You've been provided with a BST class that you'll have to use to construct the BST.
//Note that the BST class already has an insert method which you can use if you want.

//Sample Input

//array - [1, 2, 5, 7, 10, 13, 14, 15, 22]

//Sample Output

//        10
//      /    \
//    2       14
//  /  \     /  \
// 1    5  13    15
//       \        \
//        7       22

//This is one example of a BST with min height that you could create from the input array.
//You could create other BSTS with min height from the same array: for examples

//        10
//      /    \
//    5       15
//   /  \     /  \
//  2    7  13    22
// /         \
//1          14      
//------------------------------------------------------------------------------------------------------------------------------------------------------


namespace AmazonStack
{
    public class MinHeightBST
    {
		////O(nlogn) time| O(n) space, where n is length of the array
		public BST MinHeight(List<int> array)
        {
            return ConstructMinHeight(array, null, 0, array.Count - 1);
        }

		private static BST ConstructMinHeight(List<int> array, BST bst, int start, int end)
		{
			if (start > end)
				return bst;
			int mid = (start + end) / 2;
			int valueToAdd = array[mid];
			if (bst == null)
				bst = new BST(valueToAdd);
			else
				bst.Insert(valueToAdd);
			ConstructMinHeight(array, bst, start, mid - 1);
			ConstructMinHeight(array, bst, mid + 1, end);
			return bst;
		}
	}
}
