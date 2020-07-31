//------------------------------------------------------------------------------------------------------------------------------------------------------
//Question: Validate BST (AlgoExpert)
//Write a function that takes in a potentially invalid Binary Search Tree(BST) and returns a boolean representing whether the BST is valid.
//Each BST node has an integer value, a left child node, and a right child node.
//A node is said to be a valid BST node if and only if it satisfies the BST property:
//  its value is strictly greater than the values of every node to its left; its value is less than or equal to the values of every node to its right;
//  and its children nodes are either valid BST nodes themselves or None / null.

//A BST is valid if and only if all of its nodes are valid BST nodes.

//Sample Input

//tree =
//            10
//          /    \
//         5      15
//        / \    /   \
//      2    5  13   22
//     /          \
//    1            14       
//------------------------------------------------------------------------------------------------------------------------------------------------------
namespace AmazonStack
{
    public class ValidateBST
    {
		//Time complexity: O(n) where n is number of node.
		//space complexity: O(d) depth of tree.
		public bool ValidateBinarySearchTree(BST tree)
		{
			return IsBST(tree, int.MinValue, int.MaxValue);
		}
		public bool IsBST(BST tree, int minValue, int maxValue)
		{
			if (tree == null)
			{
				return true;
			}
			if (tree.value < minValue || tree.value >= maxValue)
			{
				return false;
			}
			bool isLeftBst = IsBST(tree.left, minValue, tree.value); //since it left tree maxvalue cannot be more than parent node
			bool isRightBst = IsBST(tree.right, tree.value, maxValue); //since it right tree minvalue cannot be less than parent node
			return isLeftBst && isRightBst;
		}

		
	}
}
