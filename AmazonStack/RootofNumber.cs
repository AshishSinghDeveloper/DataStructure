using System;
namespace AmazonStack
//------------------------------------------------------------------------------------------------------------------------------------------------------
//Question: Root of Number (Pramp)
//In this question we’ll implement a function root that calculates the n’th root of a number.
//The function takes a nonnegative number x and a positive integer n, and returns the positive n’th root of x within an error of 0.001
//  (i.e.suppose the real root is y, then the error is: |y-root(x, n)| and must satisfy |y-root(x, n)| < 0.001).

//Example:
//  input:  x = 7, n = 3
//  output: 1.913

//Example:
//  input:  x = 9, n = 2
//  output: 3

//Constraints:
//[time limit] 5000ms
//[input] float x
//      0 ≤ x
//[input] integer n
//       < n
//[output] float
//------------------------------------------------------------------------------------------------------------------------------------------------------
{ 
    public class RootofNumber
    {
        public float Root(int num, int root)
         {
            if(num == 0)
            {
                return 0;
            }
            //root of num should be between 0 and num
            float lowerBound = 0;
            float upperBound = Math.Max(1, num);

            float appoxRoot = (lowerBound + upperBound) / 2;

            //loop until difference betweeb appoxRoot and lowerBound is >= 0.001
            //This could also be while(upperBound - appoxRoot >= 0.001)
            while (appoxRoot - lowerBound >= 0.001)
            {
                if( Math.Pow(appoxRoot,root) > num) //if power of appoxRootm and root is greater than number then upperbound should be equal to appox number
                {
                    upperBound = appoxRoot;
                }
                else if(Math.Pow(appoxRoot,root) < num) //if appoxRoot ^ root is less than number than lowerbound should be equal to appox bumber
                {
                    lowerBound = appoxRoot;
                }
                else
                {
                    break; //if appoxRoot ^ root == num then we found the exact number so break
                }
                appoxRoot = (lowerBound + upperBound) / 2;

            }
            return appoxRoot;
        }
    }
}
