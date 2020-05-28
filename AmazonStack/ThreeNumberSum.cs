using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonStack
{
    public class ThreeNumberSum
    {
        #region Approach 1: Brute Force. O(n*n*n) where n is length of array
        //public List<List<int>> SumOfThreeNumber(int[] numbers, int target)
        //{
        //    List<List<int>> resultList = new List<List<int>>();
        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        for (int j = i+1 ; j < numbers.Length; j++)
        //        {
        //            for (int k = j+1; k < numbers.Length; k++)
        //            {
        //                if(numbers[i] + numbers[j] + numbers[k] == target)
        //                {
        //                    List<int> combintaion = new List<int>();
        //                    combintaion.Add(numbers[i]);
        //                    combintaion.Add(numbers[j]);
        //                    combintaion.Add(numbers[k]);
        //                    resultList.Add(combintaion);
        //                }
        //            }
        //        }
        //    }
        //    return resultList;
        //}
        #endregion

        #region Approach 2: Time Complexity: O(n*n) where n is length of array. Space Complexity: O(n)
        public List<List<int>> SumOfThreeNumber(int[] numbers, int target)
        {
            List<List<int>> resultList = new List<List<int>>();
            Array.Sort(numbers); //It may have time complexity of O(nlogn) in case if it using quick sort
            for (int i = 0; i < numbers.Length - 2; i++)
            {
                int current = i;
                int left = i + 1;
                int right = numbers.Length - 1;
                while (left < right)
                {
                    if (numbers[current] + numbers[left] + numbers[right] == target)
                    {
                        List<int> combintaion = new List<int>
                        {
                            numbers[current],
                            numbers[left],
                            numbers[right]
                        };
                        resultList.Add(combintaion);
                        left++;  right--;
                    }
                    else
                    {
                        if (numbers[current] + numbers[left] + numbers[right] > target)
                        {
                            right--;
                        }
                        if (numbers[current] + numbers[left] + numbers[right] < target)
                        {
                            left++;
                        }
                    } 
                }
            }
            return resultList;
        }
        #endregion
    }
}
