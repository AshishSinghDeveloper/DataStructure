using System;
//------------------------------------------------------------------------------------------------------------------------------------------------------
//Implement a function meetingPlanner that given the availability, slotsA and slotsB, of two people and a meeting duration dur,
//  returns the earliest time slot that works for both of them and is of duration dur.
//If there is no common time slot that satisfies the duration requirement, return an empty array.

//In your implementation assume that the time slots in a person’s availability are disjointed,
//  i.e, time slots in a person’s availability don’t overlap. Further assume that the slots are sorted by slots’ start time.

//Examples:

//input:  slotsA = [[10, 50], [60, 120], [140, 210]]
//        slotsB = [[0, 15], [60, 70]]
//        dur = 8
//output: [60, 68]

//input:  slotsA = [[10, 50], [60, 120], [140, 210]]
//        slotsB = [[0, 15], [60, 70]]
//        dur = 12
//output: [] # since there is no common slot whose duration is 12
//------------------------------------------------------------------------------------------------------------------------------------------------------
namespace AmazonStack
{
    public class TimePlanner
    {
        //Time: O(n|m) where n and m are length of two array. Shorter array will consider
        //Space: O(1) we are saving array of two integar. Always constant so constant
        public int[] MeetingPlanner(int[,] slotsA, int[,] slotsB, int dur)
        {
            int a = 0;
            int b = 0;
            int[] answer = new int[2];
            while (a < slotsA.Length && b < slotsB.Length)
            {
                int start = Math.Max(slotsA[a, 0], slotsB[b, 0]); 
                int end = Math.Min(slotsA[a, 1], slotsB[b, 1]);  
                if(start + dur <= end)
                {
                    answer[0] = start;
                    answer[1] = start + dur;
                    return answer;
                }
                if (slotsA[a, 1] < slotsB[b, 1])
                {
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
