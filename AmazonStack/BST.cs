using System;
namespace AmazonStack
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

		public BST Insert(int value)
		{
			BST current = this;
			BST node = new BST(value);
			while (current != null)
			{
				if (current.value > value)
				{
					if (current.left == null)
					{
						current.left = node;
						break;
					}
					else
					{
						current = current.left;
					}

				}
				else
				{
					if (current.right == null)
					{
						current.right = node;
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

		public bool Contains(int value)
		{
			BST current = this;
			while (current != null)
			{
				if (value > current.value)
					current = current.right;
				else if (value < current.value)
					current = current.left;
				else
					return true;
			}
			return false;
		}
	}

}
