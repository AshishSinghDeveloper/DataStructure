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
	}
}
