using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;

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
            string[] blocks2 = new string[] { "1", "2", "+", "Z" }; //Input score of game 2



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
            BSTNodeDistance.Node node = nums1.Insert(4);

            int nodeDistance = 0;
            int firstNodeValue = 2;
            int secondNodeValue = 4;

            //Get Lowest Common Ancestor between given values
            BSTNodeDistance.Node lcaNode = nums1.GetLowestCommonAncester(node, firstNodeValue, secondNodeValue);

            //Get distance between two node
            int distancebetweenNode = nums1.GetDistanceFromLCA(lcaNode, firstNodeValue, nodeDistance) + nums1.GetDistanceFromLCA(lcaNode, secondNodeValue, nodeDistance);
            Console.WriteLine("Distance between node {0} and node {1} is {2}", firstNodeValue, secondNodeValue, distancebetweenNode);

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
            int[,] river = new int[,] { { 1, 0, 0, 1, 0 }, { 1, 0, 1, 0, 0 }, { 0, 0, 1, 0, 1 }, { 1, 0, 1, 0, 1 }, { 1, 0, 1, 1, 0 } };

            int rowLen = river.GetLength(0);
            int colLen = river.GetLength(1);
            for (int i = 0; i < rowLen; i++)
            {
                for (int j = 0; j < colLen; j++)
                {
                    Console.Write("{0} ", river[i, j]);
                }
                Console.WriteLine();
            }

            m.RiverSize(river);
            System.Collections.Generic.List<int> riverSizes = m.RiverSize(river);
            Console.Write("River Size: ");
            foreach (var size in riverSizes)
            {
                Console.Write($" {size} ");
            }
            Console.WriteLine();
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

            #region Inputs for KClosestPointsToOrigin
            int[][] points1 = new int[][] { 
                new int[] { 1, 3 }, 
                new int[] { -2, 2 } 
            };
            int[][] points2 = new int[][]
            {
                new int[] {3,3},
                new int[] {5,-1},
                new int[] {-2,4 }
            };
            KClosestPointsToOrigin kClosestPointsToOrigin = new KClosestPointsToOrigin();
            int[][] points1ClosestToOrigin = kClosestPointsToOrigin.KClosest(points1, 1);
            int[][] points2ClosestToOrigin = kClosestPointsToOrigin.KClosest(points2, 2);
            Console.Write("Points1 closest to origin: ");
            for(int i = 0; i< points1ClosestToOrigin.Length; i++)
            {
                Console.Write($"{points1ClosestToOrigin[i][0]}, {points1ClosestToOrigin[i][1]}  ");
                    
            }
            Console.WriteLine();
            Console.Write("Points2 closest to origin: ");
            for (int i = 0; i < points2ClosestToOrigin.Length; i++)
            {
                Console.Write($"{points2ClosestToOrigin[i][0]}, {points2ClosestToOrigin[i][1]}  ");

            }
            Console.WriteLine();
            #endregion

            #region Inputs for ThreeNumberSum
            ThreeNumberSum threeNumberSum = new ThreeNumberSum();
            int[] numbers = new int[] { 12, 3, 1, 2, -6, 5, -8, 6 };
            int target = 0;
            List<List<int>> resultList = threeNumberSum.SumOfThreeNumber(numbers, target);
            Console.WriteLine("Total combinations that has sum {0} are", target);
            foreach (var result in resultList)
            {
                foreach (var item in result)
                {
                    Console.Write($" {item}");
                }
                Console.WriteLine();
            }
            #endregion

            #region Inputs for Atoi
            Atoi atoi = new Atoi();
            int atoians = atoi.MyAtoi("   -0012a42");

            Console.WriteLine("Atoi {0}",atoians);
            Console.WriteLine("Atoi {0}",atoians);
            #endregion

            #region Input for SmallestDifference
            int[] A = new int[] {-1,5,10,20,28,3 };
            int[] B = new int[] {15, 17, 26, 134, 135 };
            SmallestDifference smallestDifference = new SmallestDifference();
            int[] resultSM = smallestDifference.SmallestNumber(B, A);
            Console.WriteLine("{0} and {1} has smallest difference.", resultSM[0], resultSM[1]);
            #endregion

            #region Input for BSTOperation
            BSTOperation.BST bSTOperation = new BSTOperation.BST(10);
            BSTOperation.BST bstInsertion = bSTOperation.Insert(5, bSTOperation)
                .Insert(15,bSTOperation)
                .Insert(2, bSTOperation)
                .Insert(5, bSTOperation)
                .Insert(13, bSTOperation)
                .Insert(22, bSTOperation)
                .Insert(1, bSTOperation)
                .Insert(12, bSTOperation)
                .Insert(14, bSTOperation);

            int nodeToSearchBST = 16;
            bool bstSearch = bSTOperation.Contains(nodeToSearchBST, bSTOperation);
            Console.WriteLine("{0} exists in this BST: {1}", nodeToSearchBST, bstSearch);

            int nodeToRemoveBST = 10;
             var bstromove = bSTOperation.Remove(nodeToRemoveBST, bSTOperation);
            #endregion

            #region Input for BSTValidation
            ValidateBST.BST bst = new ValidateBST.BST(10);
            ValidateBST.BST insert = bst.Insert(5, bst)
                .Insert(15, bst)
                .Insert(2, bst)
                .Insert(5, bst)
                .Insert(13, bst)
                .Insert(22, bst)
                .Insert(1, bst)
                .Insert(12, bst)
                .Insert(14, bst);
            ValidateBST validateBST = new ValidateBST();
            validateBST.ValidateBinarySearchTree(bst);
            #endregion

            #region Input for BST Traversal
            BSTTraversal bSTTraversal = new BSTTraversal();
            BSTTraversal.BST root = new BSTTraversal.BST(10);
            root.left = new BSTTraversal.BST(5);
            root.left.left = new BSTTraversal.BST(2);
            root.left.right = new BSTTraversal.BST(5);
            root.left.left.left = new BSTTraversal.BST(1);
            root.right = new BSTTraversal.BST(15);
            root.right.left = new BSTTraversal.BST(13);
            root.right.right = new BSTTraversal.BST(22);
            root.right.left.left = new BSTTraversal.BST(12);
            root.right.left.right = new BSTTraversal.BST(14);

            List<int> nodeValue = new List<int>();
            nodeValue = bSTTraversal.InOrderTraverse(root, nodeValue);
            Console.Write("In-Order: ");
            foreach (var item in nodeValue)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            nodeValue.Clear();

            nodeValue = bSTTraversal.PreOrderTraverse(root, nodeValue);
            Console.Write("Pre-Order: ");
            foreach (var item in nodeValue)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            nodeValue.Clear();

            nodeValue = bSTTraversal.PostOrderTraverse(root, nodeValue);
            Console.Write("Post-Order: ");
            foreach (var item in nodeValue)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            #endregion

            #region AmazonQ2 (Reorder Logfiles)
            List<string> logfiles = new List<string>();
            logfiles.Add("a1 9 2 3 1");
            logfiles.Add("g1 act car");
            logfiles.Add("zo4 4 7");
            logfiles.Add("ab1 off key dog");
            logfiles.Add("a8 act zoo");
            AmazonQuestion2 amazonQuestion2 = new AmazonQuestion2();
            amazonQuestion2.reorderLines(5, logfiles.ToArray());
            #endregion

            #region Input for TimePlnner
            int[,] slotA = new int[,] { { 10, 50 }, { 60, 120 }, { 140, 210 } };
            int[,] slotB = new int[,] { { 0, 15 }, { 60, 70 } };
            int duration = 8;
            TimePlanner timePlanner = new TimePlanner();
            int[] matchingTime = timePlanner.TimeMatch(slotA, slotB, duration);
            Console.WriteLine($"Matching time is [{matchingTime[0]}, {matchingTime[1]}]");
            #endregion

            #region Input for Kadane's Algo
            int[] array = new int[] { 8, 5, -9, 1, 3, -2, 3, 4, 7, 2, -18, 6, 3, 1, -5, 6, 20, -23, 15, 1, -3, 4 };
            int[] array2 = new int[] { -1, -2, -3, -4, -5, -6, -7, -8, -9, -10 };
            KadaneAlgo kadaneAlgo = new KadaneAlgo();
            int maxSum = kadaneAlgo.KadaneAlgorithm(array);
            Console.WriteLine("Max Sum of given array is: {0}", maxSum);
            #endregion

            #region Input for SingleCycleCheck
            int[] sccArray = new int[] { 2, 2, -1 };
            SingleCycleCheck singleCycleCheck = new SingleCycleCheck();
            singleCycleCheck.HasSingleCycle(sccArray);
            #endregion

        }
    }
}
