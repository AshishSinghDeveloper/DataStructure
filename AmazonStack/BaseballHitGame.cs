using System;
using System.Collections;

namespace AmazonStack
{
    public class BaseballHitGame
    {
       
        public int CalculateScore(string[] blocks, int n)
        {
            Stack scoreStack = new Stack();
            int totalScore = 0;
            for (int i = 0; i < n; i++)
            {
                int score = 0;
                bool isInteger = int.TryParse(blocks[i], out score); //This try to parse string to int. Sucessful parse will return true with parsed value to score
                if (isInteger) //if given value is integer
                {
                    scoreStack.Push(score);
                    totalScore += score;

                }
                else //if given value is not interger. Then it could be either Z, X, or +
                {
                    if (blocks[i] == "X")
                    {
                        int doubleScore = Convert.ToInt32(scoreStack.Peek()) * 2; //Get last value and multiple by 2
                        scoreStack.Push(doubleScore);
                        totalScore += (doubleScore);
                    }
                    if (blocks[i] == "+")
                    {
                        int firstValue = Convert.ToInt32(scoreStack.Pop()); //Pop and save top value so that we can peek second value
                        int secondValue = Convert.ToInt32(scoreStack.Peek());
                        int addedValue = firstValue + secondValue;
                        scoreStack.Push(firstValue); //pushed Popped value
                        scoreStack.Push(addedValue); //pushed new added value
                        totalScore += addedValue;
                    }
                    if (blocks[i] == "Z")
                    {
                        int lastValue = Convert.ToInt32(scoreStack.Pop());
                        totalScore -= lastValue;
                    }
                }
            }
            return totalScore;
        }
    }
}
