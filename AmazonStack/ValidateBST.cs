using System;
using System.Collections.Generic;
using System.Text;

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

		public class BST
		{
			public int value;
			public BST left;
			public BST right;

			public BST(int value)
			{
				this.value = value;
			}
			public BST Insert(int value, BST root)
			{
				BST newNode = new BST(value);
				var current = root;
				//BST root;
				while (current != null)
				{
					if (value < current.value)
					{
						if (current.left == null)
						{
							current.left = newNode;
							break;
						}
						else
						{
							current = current.left; ;
						}
					}
					else
					{
						if (current.right == null)
						{
							current.right = newNode;
							break;
						}
						else
						{
							current = current.right;
						}
					}
				}
				return this;
			}
		}
		
	}
}
