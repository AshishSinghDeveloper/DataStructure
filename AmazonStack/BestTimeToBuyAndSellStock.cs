using System;
//--------------------------------------------------------------------------------------------------------
//Question: Best Time to buy and sell Stock (From Leetcode - Amazon Playlist)

//Say you have an array for which the ith element is the price of a given stock on day i.
//If you were only permitted to complete at most one transaction(i.e., buy one and sell one share of the stock),
//    design an algorithm to find the maximum profit.

//Note that you cannot sell a stock before you buy one.

//Example 1:

//Input: [7,1,5,3,6,4]
//Output: 5
//Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
//             Not 7-1 = 6, as selling price needs to be larger than buying price.

//Example 2:
//Input: [7,6,4,3,1]
//Output: 0
//Explanation: In this case, no transaction is done, i.e.max profit = 0.
//----------------------------------------------------------------------------------------------------------

namespace AmazonStack
{
    public class BestTimeToBuyAndSellStock
    {
        #region Approach 1: O(n*n)
        //public int MaxProfit(int[] prices)
        //{
        //    int mxProfit = 0;
        //    for (int i = 0; i < prices.Length; i++)
        //    {
        //        for (int j = i + 1; j < prices.Length; j++)
        //        {
        //            if (prices[i] > prices[j]) continue;
        //            int currentProfit = prices[j] - prices[i];
        //            if (currentProfit > mxProfit) mxProfit = currentProfit;
        //        }
        //    }
        //    return mxProfit;
        //}
        #endregion

        #region Approach 2: O(n)
        public int MaxProfit(int[] prices)
        {
            int mxProfit = 0;
            int minPrice = int.MaxValue;
            for(int i =0; i < prices.Length; i++)
            {
                if(prices[i] < minPrice)
                {
                    minPrice = prices[i];
                }
                else
                {
                    int currentPrice = prices[i] - minPrice;
                    if (mxProfit < currentPrice) mxProfit = currentPrice;
                }
            }
            return mxProfit;
        }
        #endregion
    }
}
