using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace AmazonStack
{
    public class KClosestPointsToOrigin
    {
        #region Approach 1 O(n)
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
            int distk = dis[K - 1];
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
            