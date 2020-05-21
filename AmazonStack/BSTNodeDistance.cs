using System;
namespace AmazonStack
{
    public class BSTNodeDistance
    {
        public class Node
        {
			public int Data;
			public Node Left, Right;
		}
		public Node Root;
		public BSTNodeDistance()
		{
			Root = null;
		}
		public Node Insert(int newNodeValue)
		{
			Node newNode = new Node();
            newNode.Data = newNodeValue;
			if (Root == null)
            {
				Root = newNode;
				return Root;
			}
			Node CurrentNode = Root;
			Node Parent;
			while (true)
			{
				Parent = CurrentNode;
				if (CurrentNode.Data < newNodeValue)
				{
					CurrentNode = CurrentNode.Right;
					if (CurrentNode == null)
					{
						Parent.Right = newNode;
						return Root;
					}
				}
				if (CurrentNode.Data > newNodeValue)
				{
					CurrentNode = CurrentNode.Left;
					if (CurrentNode == null)
					{
						Parent.Left = newNode;
						return Root;
					}
				}
			}
        }

		public Node GetLowestCommonAncester(Node node, int node1, int node2)
		{
            
			if (node.Data > node1 && node.Data > node2)
			{
				return GetLowestCommonAncester(node.Left, node1, node2);
			}
			if (node.Data < node1 && node.Data < node2)
			{
				return GetLowestCommonAncester(node.Right, node1, node2);
			}
			return node;
		}
        public int GetDistanceFromLCA(Node ancestorNode, int nodeValue, int distance)
        {
            if(ancestorNode.Data == nodeValue)
            {
				return distance;
            }
            else if(ancestorNode.Data > nodeValue)
            {
				distance += 1;
				return GetDistanceFromLCA(ancestorNode.Left, nodeValue, distance);
            }			
			distance += 1;
			return GetDistanceFromLCA(ancestorNode.Right, nodeValue, distance);			
		}
	}
}
