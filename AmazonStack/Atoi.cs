using System;
using System.Collections.Generic;
using System.Text;
//----------------------------------------------------------------------------------------------------------------------------------------------------
//Question (from Leetcode - String to integer)
//Implement atoi which converts a string to an integer.

//The function first discards as many whitespace characters as necessary until the first non-whitespace character is found.
//Then, starting from this character, takes an optional initial plus or minus sign followed by as many numerical digits as possible, and interprets them as a numerical value.

//The string can contain additional characters after those that form the integral number, which are ignored and have no effect on the behavior of this function.

//If the first sequence of non-whitespace characters in str is not a valid integral number, or if no such sequence exists because either str is empty or it contains only whitespace characters, no conversion is performed.

//If no valid conversion could be performed, a zero value is returned.

//Note:
//  - Only the space character ' ' is considered as whitespace character.
//  - Assume we are dealing with an environment which could only store integers within the 32-bit signed integer range: [−231,  231 − 1]. If the numerical value is out of the range of representable values, INT_MAX (231 − 1) or INT_MIN(−231) is returned.

//Example 1:
//Input: "42"
//Output: 42

//Example 2:
//Input: "   -42"
//Output: -42
//Explanation: The first non-whitespace character is '-', which is the minus sign.
//             Then take as many numerical digits as possible, which gets 42.

//Example 3:
//Input: "4193 with words"
//Output: 4193
//Explanation: Conversion stops at digit '3' as the next character is not a numerical digit.

//Example 4:
//Input: "words and 987"
//Output: 0
//Explanation: The first non-whitespace character is 'w', which is not a numerical
//             digit or a +/- sign.Therefore no valid conversion could be performed.

//Example 5:
//Input: "-91283472332"
//Output: -2147483648
//Explanation: The number "-91283472332" is out of the range of a 32-bit signed integer.
//             Thefore INT_MIN (−231) is returned.
//----------------------------------------------------------------------------------------------------------------------------------------------------

namespace AmazonStack
{
    public class Atoi
    {
        public int MyAtoi(string str)
        {
            long result = 0; //took long so that it could hold maximum and minimum values of int
            int max_int = Int32.MaxValue;
            int min_int = Int32.MinValue;
            str = str.Trim(); //remove all whitespace
            int sign = 1; 
            if(string.IsNullOrEmpty(str)) return (int)result; //if string is empty return 0;
            char[] charStr = str.ToCharArray(); //convert string to char array
            if (charStr[0].ToString().Equals("-")) sign = -1;//if number is negative
            for (int i = 0; i < charStr.Length; i++) 
            {
                if (char.IsDigit(charStr[i]))
                {
                    if ((result * 10 + char.GetNumericValue(charStr[i])) > max_int) //if number is greater than int max-min value 
                    {
                        result = (int)max_int;
                        if (sign == -1) result = min_int;
                        return (int)result;                        
                    }
                    else
                    {
                        result =  result * 10 + Convert.ToInt32(char.GetNumericValue(charStr[i])); //appending number
                    }
                }
                else if(i == 0 && (charStr[0].ToString().Equals("-") || charStr[0].ToString().Equals("+"))) //if first char is sign
                {
                    result = 0;
                }
                else
                {
                    break;
                }
            }
            if (sign == -1)
            {
                result *= -1;
            }
            return (int)result;
        }
    }
}
