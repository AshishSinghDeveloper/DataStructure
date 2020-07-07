namespace AmazonStack
//------------------------------------------------------------------------------------------------------------------------------------------------------
//Question: Single Cycle Check (AlgoExpert)
//You're given an array of integers where each integer represents a jump of jump its value in the array.
//For instance, the integer 2 represents a of two indices forward in the array;
//  the integer -3 represents a jump of three indices backward in the array.

//If a jump spills past the array's bounds, it wraps over to the other side.
//For instance, a jump of -1 at the index 0 brings us to the last index in the array.
//Similarly, a jump of 1 at the last index in the array brings us to index 0

//Write a function that returns a boolean representing whether the jumps in the array form a single cycle.
//A single cycle occurs if, starting at any index in the array and following the jumps,
//every element in the array is visited exactly once before landing back on the starting Index.

//Sample Input
//array = [2, 3, 1, -4, -4, 2]

//Sample Output
//true
//------------------------------------------------------------------------------------------------------------------------------------------------------
{
	public class SingleCycleCheck
	{
		//Time O(n)|| space: O(1)
		public bool HasSingleCycle(int[] array)
		{
			if (array.Length == 0)
			{
				return false;
			}
			int indexesCount = 0, startIndex = 0;
			int currentIndex = startIndex;
			while (indexesCount < array.Length)
			{
				int nextIndex = (currentIndex + array[currentIndex]) % array.Length; //using mod function to make sure nextIndex does not go out of bound
				if (nextIndex < 0)
				{
					nextIndex = nextIndex + array.Length; //when nextIndex is negative number then add array.Length to get exact circular index;
				}

				if (nextIndex == startIndex && indexesCount < array.Length - 1)
				{
					return false;
				}
				indexesCount++;
				currentIndex = nextIndex;
			}
			return currentIndex == startIndex; //if currentIndex is startIndex (0) then return true which means we successfully came back to starting point with covering all indexes
		}
	}
}
