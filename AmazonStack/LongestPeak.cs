using System;
//------------------------------------------------------------------------------------------------------------------------------------------------------
//Question: Longest Peak (AlgoExpert)
//Write a function that takes in an array of integers and returns the length of the longest peak in the array.

//A peak is defined as adjacent integers in the array that are strictly increasing until they reach a tip (the highest value in the peak),
//which point they become strictly decreasing. At least three integers are required to form a peak.

//For example, the integers 1, 4, 10, 2 form a peak, but the integers 4, 0, 10 don't and neither do the integers 1, 2, 2, 0.

//Similarly, the integers 1, 2, 3 don't form a peak because there aren't any strictly decreasing integers after the 3.

//Sample Input
//array - [1, 2, 3, 3, 4, 0, 10, 6, 5, -1, -3, 2, 3]

//Sample Output
//    6// 0, 10, 6, 5, -1, -3 
//------------------------------------------------------------------------------------------------------------------------------------------------------

namespace AmazonStack
{
	public class LongestPeak
	{
		public int LongestPeakQues(int[] array)
		{
			bool isPeakFound = false;
			int maxCount = 0;
			int count = 0;
			int peak = 0;
			for (int i = 1; i < array.Length - 1; i++)
			{
				if (array[i] > array[i - 1] && array[i] > array[i + 1])
				{
					count++;
					peak = i;
					isPeakFound = true;
				}
				if (isPeakFound)
				{
					isPeakFound = false;
					int left = i - 1;
					int center = i;
					int right = i + 1;
					while (left >= 0)
					{ //Traversing left of peak
						if (array[left] < array[center])
						{
							count++;
							center = left;
							left--;
						}
						else break;
					}
					center = peak; //re-sets center to original value of i
					while (right <= array.Length - 1)
					{ //Traversing right of peak
						if (array[right] < array[center])
						{
							count++;
							center = right;
							right++;
						}
						else break;
					}
					maxCount = maxCount > count ? maxCount : count;//calculates maxvalue after both side traversal	
					i = right - 1; // till the time we traverse to right we have no tip for next iterantion. so assigning i = right. Substracting 1 bcoz i will get increment by 1 by i++ under for loop
				}

				count = 0; // re-sets count at the end of ispeakFound 
			}
			return maxCount;
		}

		//	public int LongestPeakQues(int[] array)
		//	{
		//		if (array.Length < 3) return 0;
		//		int count = 0, maxCount = 0;
		//		int peak = Int32.MinValue;
		//		for (int i = 0; i < array.Length - 1; i++)
		//		{
		//			if (peak != Int32.MinValue)
		//			{
		//				if (array[i] > array[i + 1])
		//				{
		//					count++;
		//					if (maxCount < count)
		//					{
		//						maxCount = count;
		//					}
		//				}
		//				else
		//				{
		//					peak = Int32.MinValue;
		//					if (maxCount < count) maxCount = count;
		//					count = 0;
		//					i--;
		//				}
		//			}
		//			else if (array[i] < array[i + 1])
		//			{
		//				count++;
		//				if (array[i + 1] > array[i + 2])
		//				{
		//					count++;
		//					peak = array[i + 1];
		//				}
		//			}
		//			else if (array[i] == array[i + 1])
		//			{
		//				peak = Int32.MinValue;
		//				if (maxCount < count) maxCount = count;
		//				count = 0;
		//			}
		//		}
		//		return maxCount;
		//	}
		//O(n) Time | O(1) Space, where n is length of input array


	}
}
