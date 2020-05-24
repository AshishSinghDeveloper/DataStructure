using System;
using System.Collections;

namespace AmazonStack
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Inputs for BaseballHitGame
            //Related to first question
            BaseballHitGame P = new BaseballHitGame();
            string[] blocks = new string[] { "5", "-2", "4", "Z", "X", "9", "+", "+" }; //Input score of game 1
            string[] blocks2 = new string[] { "1", "2", "+", "Z"}; //Input score of game 2

            

            //Total score of first game
            int finalScore = P.CalculateScore(blocks, 8);
            Console.WriteLine(finalScore);

            //Total score of second game
            int finalScore2 = P.CalculateScore(blocks2, 4);
            Console.WriteLine(finalScore2);
            #endregion

            #region Inputs for BSTNodeDistance            
            //Creating BST
            BSTNodeDistance nums1 = new BSTNodeDistance();
            nums1.Insert(5);
            nums1.Insert(6);
            nums1.Insert(3);
            nums1.Insert(1);
            nums1.Insert(2);
            BSTNodeDistance.Node node =  nums1.Insert(4);

            int nodeDistance = 0;
            int firstNodeValue = 2;
            int secondNodeValue = 4;

            //Get Lowest Common Ancestor between given values
            BSTNodeDistance.Node lcaNode =  nums1.GetLowestCommonAncester(node, firstNodeValue, secondNodeValue);

            //Get distance between two node
            int distancebetweenNode = nums1.GetDistanceFromLCA(lcaNode, firstNodeValue, nodeDistance) + nums1.GetDistanceFromLCA(lcaNode, secondNodeValue, nodeDistance);
            Console.WriteLine("Distance between node {0} and node {1} is {2}",firstNodeValue, secondNodeValue, distancebetweenNode);

            LongestSubStringWithRepeatingCharacter longest = new LongestSubStringWithRepeatingCharacter();
            longest.SlidingWindow("abccccef");
            #endregion

            #region Inputs for AddLinkedListNumber
            //first linkedList
            AddLinkedListNumber.ListNode nodethree = new AddLinkedListNumber.ListNode();
            nodethree.val = 3;
            nodethree.next = null;

            AddLinkedListNumber.ListNode nodeTwo = new AddLinkedListNumber.ListNode();
            nodeTwo.val = 4;
            nodeTwo.next = nodethree;

            AddLinkedListNumber.ListNode nodeOne = new AddLinkedListNumber.ListNode();
            nodeOne.val = 5;
            nodeOne.next = null;

            AddLinkedListNumber.ListNode firstList = new AddLinkedListNumber.ListNode();
            firstList = nodeOne;

            //seond linkedlist   
            AddLinkedListNumber.ListNode node2three = new AddLinkedListNumber.ListNode();
            node2three.val = 4;
            node2three.next = null;

            AddLinkedListNumber.ListNode node2Two = new AddLinkedListNumber.ListNode();
            node2Two.val = 6;
            node2Two.next = node2three;

            AddLinkedListNumber.ListNode node2One = new AddLinkedListNumber.ListNode();
            node2One.val = 5;
            node2One.next = null;

            AddLinkedListNumber.ListNode secondList = new AddLinkedListNumber.ListNode();
            secondList = node2One;

            AddLinkedListNumber.Solution listnode = new AddLinkedListNumber.Solution();
            listnode.AddTwoNumbers(firstList, secondList);
            #endregion

            #region Inputs for MatrixQuestion
            MatrixQuestion m = new MatrixQuestion();
            int[,] river = new int[,] { { 0, 0, 0, 1, 0 }, { 1, 0, 1, 0, 0 }, { 0, 0, 1, 0, 1 }, { 1, 0, 1, 0, 1 }, { 1, 0, 1, 1, 0 } };
            
            int rowLen = river.GetLength(0);
            int colLen = river.GetLength(1);
            for (int i = 0; i < rowLen; i++)
            {
                for (int j = 0; j < colLen; j++)
                {
                    Console.Write("{0} ",river[i,j]);
                }
                Console.WriteLine();
            }

            m.RiverSize(river);
            #endregion

            #region Inputs for BestTimeToBuyAndSellStock
            BestTimeToBuyAndSellStock bestTimeToBuyAndSellStock = new BestTimeToBuyAndSellStock();
            int[] stockPrice1 = new int[] { 7, 1, 5, 3, 6, 4 };
            int[] stockPrice2 = new int[] { 7, 6, 4, 3, 1 };
            int maxProfit1 = bestTimeToBuyAndSellStock.MaxProfit(stockPrice1);
            Console.WriteLine("Max Profit Possible for StockPrice1: {0}", maxProfit1);
            int maxProfit2 = bestTimeToBuyAndSellStock.MaxProfit(stockPrice2);
            Console.WriteLine("Max Profit Possible for StockPrice2: {0}", maxProfit2);
            #endregion

        }
    }
}
