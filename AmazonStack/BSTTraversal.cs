using System;
using System.Collections.Generic;
//---------------------------------------------------------------------------------------------
//Quesion: BST Traversal (AlgoExpert)

//Write three functions that take in a Binary Search Tree (BST) and an empty array, traverse the BST,
//    add its nodes'values to the input array, and return that array.
//The three functions should traverse the BST using the in-order, pre-order, and post-order tree-traversal techniques, respectively.

//Each BST node has an integer value, a left child node, and a right child node.
//A node is said to be a valid BST node if and only if it satisfies the BST property:
//  -its value is strictly greater than the values of every node to its left;
//  -its value is less than or equal to the values of every node to its right;
//  -and its children nodes are either valid BST nodes themselves or None / null.

//Sample Input

//            10
//          /    \
//         5      15
//        / \    /   \
//      2    5  13   22
//     /          \
//    1            14       
//array = []

//Sample output
//inorder Traversal: [1, 2, 5, 5, 10, 13, 14, 22, 15]  // where the array is the input array
//preOrder Traversal: [10, 5, 2, 1, 5, 15, 13, 14, 22] // where the array is the input array
//postorder Traversal: [1, 2, 5, 5, 14, 13, 22, 15 10] // where the array is the input array
//---------------------------------------------------------------------------------------------

namespace AmazonStack
{
    public class BSTTraversal
    {
        //Time: O(n) where n is  number of node.
        //Space: O(n) where n is length of array. If we are not storing array and thus print node.value then space complexity will be O(d) where d is depth of tree.
        public List<int> InOrderTraverse(BST tree, List<int> array)
        {
            if(tree.left != null)
            {
                InOrderTraverse(tree.left, array);
            }
            array.Add(tree.value);
            if(tree.right != null)
            {
                InOrderTraverse(tree.right, array);
            }
            return array;
        }
        public List<int> PreOrderTraverse(BST tree, List<int> array)
        {
            array.Add(tree.value);
            if(tree.left != null)
            {
                PreOrderTraverse(tree.left, array);
            }
            if(tree.right != null)
            {
                PreOrderTraverse(tree.right, array);
            }
            return array;
        }
        public List<int> PostOrderTraverse(BST tree, List<int> array)
        {
            if(tree.left != null)
            {
                PostOrderTraverse(tree.left, array);
            }
            if(tree.right != null)
            {
                PostOrderTraverse(tree.right, array);
            }
            array.Add(tree.value);
            return array;
        }

        public class BST
        {
            public int value;
            public BST left;
            public BST right;

            public BST(int value)
            {
                this.value = value;
            }
        }
    }
    
}
