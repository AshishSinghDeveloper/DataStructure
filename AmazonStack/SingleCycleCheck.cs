using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonStack
{
	public class SingleCycleCheck
	{
		public bool HasSingleCycle(int[] array)
		{
			if (array.Length == 0)
			{
				return false;
			}
			int currentIndex = 0, startIndex = 0;
			int count = 0;
			HashSet<int> indexes = new HashSet<int>();
			indexes.Add(startIndex);
			while (count <= array.Length)
			{
				count++;
				int nextIndex = currentIndex + array[currentIndex];
				if (nextIndex < 0)
				{
					//while(nextIndex < 0){
					//int remainingIndex = array[nextIndex] + currentIndex;
					nextIndex = array.Length + nextIndex;
					//}
				}
				else if (nextIndex > array.Length - 1)
				{
					//while(nextIndex > array.Length){
					nextIndex = nextIndex- (array.Length);
					//}
				}

				if (indexes.Contains(nextIndex))
				{
					if (nextIndex == startIndex && indexes.Count == array.Length)
					{
						return true;
					}
					else
					{
						return false;
					}
				}
				else
				{
					indexes.Add(nextIndex);
					currentIndex = nextIndex;
				}

			}
			return false;

		}
	}
}
