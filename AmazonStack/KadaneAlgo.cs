using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonStack
{
    public class KadaneAlgo
    {
  //      public int KadaneAlgorithm(int[] array)
  //      {
		//	if (array.Length == 0)
		//	{
		//		return 0;
		//	}
		//	int start = 0, end = array.Length - 1;
		//	int startPeek = start, endPeek = end;
		//	int maxSum = GetSum(start, end, array), localSum = maxSum;
		//	List<int> loc = new List<int>();
		//	while (startPeek <= endPeek)
		//	{
		//		loc.Add(localSum);
		//		if (localSum > maxSum)
		//		{
		//			maxSum = localSum;
		//		}
		//		if (array[startPeek] < array[endPeek])
		//		{
		//			if (array[startPeek] < 0)
		//			{
		//				start = startPeek + 1;
		//				localSum = GetSum(start, end, array);
		//				startPeek = start;
		//				continue;
		//			}
		//			else
		//			{
		//				localSum = GetSum(startPeek, end, array);
		//				loc.Add(localSum);
		//				startPeek++;
		//				localSum = GetSum(startPeek, end, array);
		//				loc.Add(localSum);
		//			}
		//		}
		//		else
		//		{
		//			if (array[endPeek] < 0)
		//			{
		//				end = endPeek - 1;
		//				localSum = GetSum(start, end, array);
		//				endPeek = end;
		//				continue;
		//			}
		//			else
		//			{
		//				localSum = GetSum(start, endPeek, array);
		//				loc.Add(localSum);
		//				endPeek--;
		//				localSum = GetSum(start, endPeek, array);
		//				loc.Add(localSum);
		//			}
		//		}
		//	}
		//	return maxSum;
		//}

		private static int GetSum(int start, int end, int[] array)
		{
			int sum = 0;
			for (int i = start; i <= end; i++)
			{
				sum += array[i];
			}
			return sum;
		}
		public int KadaneAlgorithm(int[] array)
		{
			List<string> val = new List<string>();
			if (array.Length == 0) return 0;
			int maxEndingHere = array[0];
			int maxSoFar = array[0];
			for (int i = 1; i < array.Length; i++)
			{
				maxEndingHere = Math.Max(array[i], maxEndingHere + array[i]);
				maxSoFar = Math.Max(maxEndingHere, maxSoFar);
				val.Add($"maxEndlingHere: {maxEndingHere} maxSoFar: {maxSoFar}");
			}
			return maxSoFar;
		}
	}

	
}
