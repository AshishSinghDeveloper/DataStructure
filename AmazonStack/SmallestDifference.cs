using System;
//------------------------------------------------------------------------------------------------------------------------------------------------------
//Question: Smallest Difference (algoExpert)
//Write a function that takes in two non-empty arrays of integers,
//  find the pair of numbers(one from each array) whose absolute difference is closest to zero,
//  and returns an array containing these two numbers, with the number from the first array in the first position.

//You can assume that there will only be one pair of numbers with the smallest difference.

//Sample Input
//arrayOne = [-1, 5, 10, 20, 28 3]
//arrayTwo = [26, 134, 135, 15, 17]

//Sample Output
//[28, 26)
//------------------------------------------------------------------------------------------------------------------------------------------------------
namespace AmazonStack
{
    public class SmallestDifference
    {
		//Time Complexity: O(nlogn+ mlogm) where n and m are length of array. Array.Sort() takes xlogx that's why we got this time complexity. while loop will just take O(n+m)
		//Space Complexity: O(1). constant.
		public int[] SmallestNumber(int[] A, int[] B)
		{
			Array.Sort(A); // It should have time complexity of O(nlogn)
			Array.Sort(B); // It should have time complexity of O(mlogm)
            int I = 0, j = 0, min = Int32.MaxValue;
			int[] answer = new int[2];
			while (I < A.Length && j < B.Length)
			{
				int diff = Math.Abs(A[I] - B[j]);
                if (diff < min)
				{
					min = diff;
					answer[0] = A[I];
					answer[1] = B[j];
				}
				if (A[I] < B[j]) I++;
				else j++;
			}
            return answer;
		}
	}
}
