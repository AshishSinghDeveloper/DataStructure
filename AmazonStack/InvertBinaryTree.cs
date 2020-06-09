using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonStack
{
    public class InvertBinaryTree
    {
        public void InvertBT(BinaryTree tree)
        {
			List<BinaryTree> Queue = new List<BinaryTree>();
			int index = 0;
			Queue.Add(tree);
			while (index < Queue.Count)
			{
				BinaryTree current = Queue[index];
				index += 1;

				if (current == null)
				{
					continue;
				}

				InvertTree(current);

				if (current.left != null)
				{
					Queue.Add(current.left);
				}

				if (current.right != null)
				{
					Queue.Add(current.right);
				}
			}
		}

		public static void InvertTree(BinaryTree tree)
		{
			BinaryTree tempLeft = tree.left;
			tree.left = tree.right;
			tree.right = tempLeft;

		}

		public class BinaryTree
		{
			public int value;
			public BinaryTree left;
			public BinaryTree right;

			public BinaryTree(int value)
			{
				this.value = value;
			}
		}


	}
}
