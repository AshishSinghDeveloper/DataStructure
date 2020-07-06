using System;
//------------------------------------------------------------------------------------------------------------------------------------------------------
//Question: K Closest Points to Origin (Leetcode - Amazon Playlist)

//We have a list of points on the plane. Find the K closest points to the origin(0, 0).
//(Here, the distance between two points on a plane is the Euclidean distance.)
//You may return the answer in any order.The answer is guaranteed to be unique (except for the order that it is in.)

//Example 1
//Input: points = [[1,3],[-2,2]], K = 1
//Output: [[-2,2]]
//Explanation: 
//  The distance between(1, 3) and the origin is sqrt(10).
//  The distance between(-2, 2) and the origin is sqrt(8).
//  Since sqrt(8) < sqrt(10), (-2, 2) is closer to the origin.
//  We only want the closest K = 1 points from the origin, so the answer is just[[-2, 2]].

//Example 2:
//Input: points = [[3,3],[5,-1],[-2,4]], K = 2
//Output: [[3,3],[-2,4]]
//(The answer [[-2, 4],[3,3]] would also be accepted.)
//------------------------------------------------------------------------------------------------------------------------------------------------------

namespace AmazonStack
{
    public class KClosestPointsToOrigin
    {
        #region Approach 1 O(nlogn)
        //public int[][] KClosest(int[][] points, int k)
        //{
        //    List<PointsAndDistane> list = new List<PointsAndDistane>();
        //    for(int i = 0; i < points.Length; i++)
        //    {
        //        PointsAndDistane pd = new PointsAndDistane();
        //        pd.x = points[i][0];
        //        pd.y = points[i][1];
        //        pd.distance = Math.Sqrt((pd.x * pd.x) + (pd.y * pd.y));
        //        list.Add(pd);
        //    }
        //    list.Sort();
        //    int[][] answer = new int[k][];
        //    for (int i = 0; i < answer.Length; i++)
        //    {
        //        answer[i] = new int[] { list[i].x, list[i].y };
        //    }
        //    return answer;
        //}
        #endregion

        #region Approach 2 O(nlogn)
        public int[][] KClosest(int[][] points, int K)
        {
            int N = points.Length;
            int[] dis = new int[N];
            for (int i = 0; i < N; i++)
            {
                dis[i] = DistanceFromOrigin(points[i]);
            }
            Array.Sort(dis);
            int distk = dis[K - 1]; //now it has lowest k-1 number
            int[][] answer = new int[K][];
            int t = 0;

            for(int i = 0; i < N; i++)
            {
                if(DistanceFromOrigin(points[i]) <= distk)
                {
                    answer[t++] = points[i];
                }
            }
            return answer;
            #endregion
        }

        private int DistanceFromOrigin(int[] point)
        {
            return point[0] * point[0] + point[1] * point[1];
        }
    }        

}
            