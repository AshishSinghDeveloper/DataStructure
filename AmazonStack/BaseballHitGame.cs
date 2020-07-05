using System;
using System.Collections;
using System.Collections.Generic;
//--------------------------------------------------------------------------------------------------------------------------------------------------------
//Amazon Question (05-17-2017)
//John plays a game in which he throws a baseball at various blocks marked with a symbol so as to knock these out.
//A score is computed for each throw. The last score" is the score of the previous throw (or 0, if there is no previous throw) and
//the total score is the sum of the scores of all the throws.
//The symbol on a block can be an integer, a sign or a letter. Each sign or letter represents a special rule as given below:
//    - If a throw hits a block marked with an integer, the score for that throw is the value of that integer.
//    - If a throw hits a block marked with an 'X', the score for that throw is double the last score.
//    - If a throw hits a block marked with a '+', the score for that throw is the sum of the last two scores.
//    - If a throw hits a block marked with a 'Z', the last score is removed, as though the last throw never happened. Its value does not count towards the total score,
//     and the subsequent throws will ignore it when computing their values (see example below).

//Write an algorithm that computes the total score for a given list of ordered hits by John.

//Input
//The input to the function/method consists of two arguments - blocks, representing a list of symbols and n, an integer representing the number of symbols in the list.

//Output
//Return an integer representing the total score for the given list of ordered hits.

//Example
//Input:
//blocks = [5, -2, 4, Z, X, 9, +, +), n = 8

//Output:
//27

//Explanation:
//After the block marked with 5 is hit, the current score is 5 and the total score is 5.
//After the block marked with -2 is hit, the current score is -2 and the total score is 3.
//After the block marked with 4 is hit, the current score is 4 and the total score is 7.
//After the block marked th 'Z is hit, the previous throw never happened, so the total score goes back to 3.
//After the block marked with 'X' is hit, the current score is 2-2 = -4 and the total score is -1.
//    (remember, throws after a Z ignore the removed score when computing their values).
//After the block marked with 9 is hit the current score is 9 and the total score is 8.
//After the block marked with '+' is hit, the current score is -4 + 9 = 5 and the total score is 13
//After the block marked with '+' is hit, the current score is 9 +5 = 14 and the total score is 27
//--------------------------------------------------------------------------------------------------------------------------------------------------------

namespace AmazonStack
{
    public class BaseballHitGame
    {
       
        public int CalculateScore(string[] blocks, int n)
        {
            Stack<int> scoreStack = new Stack<int>();
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
                        int doubleScore = scoreStack.Peek() * 2; //Get last value and multiple by 2
                        scoreStack.Push(doubleScore);
                        totalScore += doubleScore;
                    }
                    if (blocks[i] == "+")
                    {
                        int firstValue = scoreStack.Pop(); //Pop and save top value so that we can peek second value
                        int secondValue = scoreStack.Peek();
                        int addedValue = firstValue + secondValue;
                        scoreStack.Push(firstValue); //pushed Popped value
                        scoreStack.Push(addedValue); //pushed new added value
                        totalScore += addedValue;
                    }
                    if (blocks[i] == "Z")
                    {
                        int lastValue = scoreStack.Pop();
                        totalScore -= lastValue;
                    }
                }
            }
            return totalScore;
        }
    }
}
