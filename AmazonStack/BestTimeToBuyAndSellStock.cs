using System;
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
