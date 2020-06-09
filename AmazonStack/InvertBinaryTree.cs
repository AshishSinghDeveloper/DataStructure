using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Text;

namespace AmazonStack
{
    public class InvertBinaryTree
    {
		//Time complexity: O(n) where n is number of node. We got this complexity because we are using while loop for each node
		//Space Complexity: O(n) where n is number of node. We got this complexity because we are store all nodes in queue
        public void InvertBT(BinaryTree tree)
		{ 	
			//we are using BFS search here. You can guess this with Queue.
			//In general, for implementing BFS we use Queue and for DFS we use Stack.
			Queue<BinaryTree> queue = new Queue<BinaryTree>();
			queue.Enqueue(tree);
			while(queue.Count > 0)
			{ 
				BinaryTree current = queue.Dequeue();
				if (current == null)
				{
					continue;
				}

				InvertTree(current);

				if (current.left != null)
				{
					queue.Enqueue(current.left);
				}
				if (current.right != null)
				{
					queue.Enqueue(current.right);
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

			public void insert(int[] num, int root)
            {
				
                for (int i = 0; i < num.Length; i++)
                {
					BinaryTree newNode = new BinaryTree(num[i]);

				}
				
            }
		}


	}
}
