using System.Collections.Generic;

namespace AmazonStack
{
    public class BinaryTree
    {
        public int value;
        public BinaryTree left;
		public BinaryTree right;

        public BinaryTree(int value)
        {
            this.value = value;
            this.left = null;
            this.right = null;
        }

        public BinaryTree()
        {

        }
        public void ContinuousInsert(int value)
        {
            BinaryTree current = this;
            BinaryTree newNode = new BinaryTree(value);
            Queue<BinaryTree> queue = new Queue<BinaryTree>();
            queue.Enqueue(current);
            while(queue != null)
            {
                var temp = queue.Dequeue();

                if (temp.left == null)
                {
                    temp.left = newNode;
                    break;
                }
                else
                    queue.Enqueue(temp.left);

                if (temp.right == null)
                {
                    temp.right = newNode;
                    break;
                }
                else
                    queue.Enqueue(temp.right);
            }
            
        }
        public BinaryTree SimpleBinaryTree()
        {
            BinaryTree binaryTree = new BinaryTree(1);
            binaryTree.ContinuousInsert(2);
            binaryTree.ContinuousInsert(3);
            binaryTree.ContinuousInsert(4);
            binaryTree.ContinuousInsert(5);
            binaryTree.ContinuousInsert(6);
            binaryTree.ContinuousInsert(7);
            binaryTree.ContinuousInsert(8);
            binaryTree.ContinuousInsert(9);
            binaryTree.ContinuousInsert(10);
            binaryTree.ContinuousInsert(11);


            return binaryTree;
        }
    }
    
}
