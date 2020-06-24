using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonStack
{
    public class TimePlanner
    {

        //From Pramp
        //Time: O(n|m) where n and m are length of two array. Shorter array will consider
        //Space: O(1) we are saving array of two integar. Always constant so constant
        public int[] TimeMatch(int[,] setA, int[,] setB, int dur)
        {
            int a = 0;
            int b = 0;
            int[] answer = new int[2];
            while (a < setA.Length && b < setB.Length)
            {
                int start = Math.Max(setA[a, 0], setB[b, 0]); // Math.Max(setA[a][0], setB[b][0]);
                int end = Math.Min(setA[a, 1], setB[b, 1]);  //Math.Min(set[a][1], setB[b][1]);
                if(start + dur <= end)
                {
                    answer[0] = start;
                    answer[1] = start + dur;
                    return answer;
                }
                if (setA[a, 1] < setB[b, 1])
                { //if(setA[a][1]] < setB[b][1])
                    a++;
                }
                else
                {
                    b++;
                }
            }
            return answer;
        }
        
    }
}
