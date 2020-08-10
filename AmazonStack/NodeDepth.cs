//------------------------------------------------------------------------------------------------------------------------------------------------------
//Question:  Node Depths (AlgoExpert)

//The distance between a node in a Binary Tree and the tree's root is called the node's depth.
//Write a function that takes in a Binary Tree and returns the sum of its nodes' depths.

//Sample Input
//tree =
//        1
//      /    \
//    2        3
//   /  \     /  \
//  4    5   6    7
// / \  /
//8  9 10    

//Sample Output
//16

// The depth of the node with value 2 is 1.
// The depth of the node with value 3 is 1.
// The depth of the node with value 4 is 2.
// The depth of the node with value 5 is 2.
// Etc..

// Summing all of these depths yields 16.
//------------------------------------------------------------------------------------------------------------------------------------------------------
namespace AmazonStack
{
    public class NodeDepth
    {
        public int GetDepthSum(BinaryTree root)
        {
            return GetBinaryTreeDepth(root, 0);
		}
        public int GetBinaryTreeDepth(BinaryTree root, int depth)
        {
            if (root == null)
            {
                return 0;
            }     
            return depth + GetBinaryTreeDepth(root.left, depth + 1) + GetBinaryTreeDepth(root.right, depth + 1);
        }
    }
}
