using System;
using System.Collections.Generic;
using System.Text;

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
				else if (A[I] > B[j]) j++;
			}
            return answer;
		}
	}
}
