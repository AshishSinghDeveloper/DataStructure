using System;
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
            if (start == 0 && arr[start] == start) return ++start;
            else if (start == 0) return 0;
            else if (start == arr.Length - 1 && start == arr[start]) return ++start;
            else return arr[start - 1] + 1;           
        }
    }
}
