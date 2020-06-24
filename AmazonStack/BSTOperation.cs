using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonStack
{
    public class BSTOperation
    {
		public class BST
		{
			public int value;
			public BST left;
			public BST right;

			public BST(int value)
			{
				this.value = value;
			}
			//Average: O(log(n)) time | O(1) space
			//worst: O(n) time | O(1) space
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
							current = current.left;;
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

			//Average: O(log(n)) time | O(1) space
			//worst: O(n) time | O(1) space
			public bool Contains(int value, BST root)
			{
				var current = root;
				while (current != null)
				{
					if (current.value == value)
					{
						return true;
					}
					else if (value > current.value)
					{
						current = current.right;
					}
					else
					{
						current = current.left;
					}
				}
				return false;
			}

			//Average: O(log(n)) time | O(1) space
			//worst: O(n) time | O(1) space
			public BST Remove(int value, BST root, BST parentNode = null)
			{
				var current = root;
				//BST parentNode = null;
				while (current != null)
				{
					if (value < current.value)
					{
						parentNode = current;
						current = current.left;
					}
					else if (value > current.value)
					{
						parentNode = current;
						current = current.right;
					}
                    else //Value found. It is in current node
                    {
						//When node we want to delete has both child. This could be root note too
						if(current.left != null && current.right != null)
                        {
							var minRight = current.right;
							while (minRight.left != null)
							{
								minRight = minRight.left;
							}
							current.right.Remove(minRight.value, current);
							current.value = minRight.value;
							break;
							
						}
						//When node we want to delete is root node whose only one child exists
						else if (parentNode == null)
                        {
							if(current.left != null)
                            {
								var leftNode = current.left;
								current.value = leftNode.value;
								current.left = leftNode.left;
								current.right = leftNode.right;
								break;
                            }
							else if (current.right != null)
                            {
								var rightNode = current.right;
								current.value = rightNode.value;
								current.left = rightNode.left;
								current.right = rightNode.right;
								break;
                            }
                            else //when root note is only node in the tree.
                            {
								current = null;//this technically not doing anything. You can do current.value = 0;
								break;
                            }
                        }
						//when we want to delete node which is not root node and only has left child
						else if(parentNode.left == current)
                        {
							parentNode.left = current.left ?? current.right;
							break;
                        }
						//when we want to delete node which ic not root node and only has right child
						else if(parentNode.right == current)
                        {
							parentNode.right = current.left ?? current.right;
							break;
                        }
                    }
				}
				return this;
			}
		}
	}
}
