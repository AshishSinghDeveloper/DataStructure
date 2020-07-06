using System;
//------------------------------------------------------------------------------------------------------------------------------------------------------
//Question: Kadane's algorithm (AlgoExpert)
//Write a function that takes In a non-empty array of Integers and
// returns the maximum sum that can be obtained by summing up all of the Integers in a non-empty subarray of the Input array,
// A subarray must only contain adjacent numbers.

//Sample Input
//array = [3, 5, -9, 1, 3, -2, 3, 4, 7, 2, -9, 6, 3, 1, -5, 4]

//Sample Output
// 19

//Explaination
//[1, 3, -2, 3, 4, 7, 2, -9, 6, 3, 1] this has maximum adjacent sum
//------------------------------------------------------------------------------------------------------------------------------------------------------
namespace AmazonStack
{
	public class KadaneAlgo
	{
		//  public int KadaneAlgorithm(int[] array)
		//  {
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

		//private static int GetSum(int start, int end, int[] array)
		//{
		//	int sum = 0;
		//	for (int i = start; i <= end; i++)
		//	{
		//		sum += array[i];
		//	}
		//	return sum;
		//}
		public int KadaneAlgorithm(int[] array)
		{
			int maxEndingHere = array[0];
			int maxSoFar = array[0];
			for (int i = 1; i < array.Length; i++)
			{
				maxEndingHere = Math.Max(array[i], maxEndingHere + array[i]);
				maxSoFar = Math.Max(maxEndingHere, maxSoFar);
			}
			return maxSoFar;
		}
	}
}
