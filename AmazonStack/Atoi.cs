using System;
using System.Collections.Generic;
using System.Text;

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
