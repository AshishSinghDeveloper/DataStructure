using System;
namespace AmazonStack
{
    public class RootofNumber
    {
        public float Root(int num, int root)
         {
            if(num == 0)
            {
                return 0;
            }
            float lowerBound = 0;
            float upperBound = Math.Max(1, num);
            float appoxRoot = (lowerBound + upperBound) / 2;
           // while (appoxRoot - lowerBound >= 0.001)
            while(upperBound - appoxRoot >=0.001)
            {
                if( Math.Pow(appoxRoot,root) > num)
                {
                    upperBound = appoxRoot;
                }
                else if(Math.Pow(appoxRoot,root) < num)
                {
                    lowerBound = appoxRoot;
                }
                else
                {
                    break;
                }
                appoxRoot = (lowerBound + upperBound) / 2;

            }
            return appoxRoot;
        }
    }
}
