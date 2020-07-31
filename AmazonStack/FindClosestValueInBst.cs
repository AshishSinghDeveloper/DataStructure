using System;
namespace AmazonStack
//------------------------------------------------------------------------------------------------------------------------------------------------------
//Question: Find Closest Value In BST (AlgoExpert)

//Write a function that takes in a Binary Search Tree(BST) and a target integer value and returns the closest value to that target value contained in the BST.
//You can assume that there will only be one closest value.

//Sample Input
//tree = 10
//            10
//          /    \
//         5      15
//        / \    /   \
//      2    5  13   22
//     /          \
//    1            14       

//Sample Output
//13
//------------------------------------------------------------------------------------------------------------------------------------------------------
{
	public class FindClosestValueInBst
    {
		public int FindClosestValueInBstQues(BST tree, int target)
		{
			if (tree == null) return 0;
			BST parent = tree;
			BST traversal = tree;
			while (traversal.left != null && traversal.right != null)
			{
				if (traversal.value > target)
				{
					parent = traversal;
					traversal = traversal.left;
				}
				else if (traversal.value < target)
				{
					parent = traversal;
					traversal = traversal.right;
				}
				else if (traversal.value == target)
				{
					if (traversal.right != null && traversal.left != null)
					{
						return Math.Min(traversal.right.value, traversal.left.value);
					}
					else if (traversal.right == null)
					{
						return traversal.left.value;
					}
					else if (traversal.left == null)
					{
						return traversal.right.value;
					}
				}
			}
			return traversal.value;
		}

	}

	
}
