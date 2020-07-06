using System;
//------------------------------------------------------------------------------------------------------------------------------------------------------
//Question: Getting a different number (Pramp)
//Given an array arr of unique nonnegative integers, implement a function getDifferentNumber that finds the smallest nonnegative integer that is NOT in the array.

//Example:

//input:  arr = [0, 1, 2, 3]

//output: 4

//Constraints:
//[time limit] 5000ms

//[input] array.integer arr
//  - 1 ≤ arr.length ≤ MAX_INT
//  - 0 ≤ arr[i] ≤ MAX_INT for every i, 0 ≤ i<MAX_INT
//[output] integer
//------------------------------------------------------------------------------------------------------------------------------------------------------
namespace AmazonStack
{
    //Time: O(n) and Space: O(1) where n is length of array
    public class GetDifferentNum
    {
        public int GetDifferentNumber(int[] arr)
        {
            //To solve this we are trying to keep element as per index such that
            //arr[value] == index where value == index
            int start = 0;
            int end = arr.Length - 1;
            //loop until start does not become equal to end
            while (start < end)
            {
                //Case1: When element is at its correct index
                if (arr[start] == start)
                {
                    start++;
                }
                //Case2: When value of particular array element is less than array length then
                //swap element
                else if (arr[start] < arr.Length)
                {
                    int temp = arr[arr[start]];
                    arr[arr[start]] = arr[start];
                    arr[start] = temp;
                }
                //Case3: When value of particular array element is greater than length then
                //swap element with end
                else
                {
                    int temp = arr[end];
                    arr[end] = arr[start];
                    arr[start] = temp;
                    end--;
                }
            }
            //Now start = end
            if (start == 0 && arr[start] == start) return ++start; //when array has only one element 0
            else if (start == 0) return 0; //when array has no element
            else if (start == arr.Length - 1 && start == arr[start]) return ++start;//when start reach to last element and number in its index position
            else return arr[start - 1] + 1; //general case          
        }
    }
}
