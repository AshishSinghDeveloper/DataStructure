using System;
using System.Collections.Generic;

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
