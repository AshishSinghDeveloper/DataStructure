using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//--------------------------------------------------------------------------------------
//Question
//You have been given a task of reordering some data from a log file.
//In the log file, every line is a space-delimited list of strings, all lines begin with an alphanumeric identifier.
//There will be no lines consisting only of an identifier.
//After the alphanumeric identifier, a line will consist of either:

//a list of words using only lowercase English letters,
//or list of only integers

//You have to reorder the data such that all of the lines with words are at the top of the log file.
//The ines with words are ordered alphabetically, ignoring the identifier except in the case of ties.
//In the case of ties (if the are two lines that are identical except for the identifier), the identifier is used to order alphabetically.
//Alphanumeric should be sorted in ASCII order numbers come before letters).
//The identifiers must still be part of the lines in the output strings.
//Lines with integers must be left in the original order they were in the file.

//Write an algorithm to reorder the data in the log file, according to the rules above.
//Input
//The input to the function/method consists of two arguments
//  - log File Size, an integer representing the number of log lines.
//  - loglines, a list of strings representing the log file.

//Output
//Return a list of strings representing the reordered log file data.

//Note Identifier consists of enly lower case English characters and numbers

//Example
//Input:
//log File Size=5
//loglines =
//[al 9 2 3 1]
//[gl act car]
//[z04 4 7]
//[ab1 off key dog]
//[a8 act zoo]

//Output
//[gl act car]
//[a8 act zoo]
//[abl off key dog]
//[al 9 2 3 1 ]
//[zo4 4 7]

//Explanation:
//Second, fourth, and fifth lines are the lines with words.
//According to the alphabetical order, the second life will be reordered first in the log file,
//then fifth and the fourth comes in the log file.
//Next, the lines with numbers come in the order in which these lines were in the input
//---------------------------------------------------------------------------------------------

namespace AmazonStack
{
    public class AmazonQuestion2
    {
        //public List<string> reorderLines(int logFileSize, string[] logLines)
        //{
        //    Array.Sort(logLines, (log1, log2) =>
        //    {
        //        string[] split1 = log1.Split(" ", 2);
        //        string[] split2 = log2.Split(" ", 2);
        //        bool isDigit1 = char.IsDigit(split1[1][0]);
        //        bool isDigit2 = char.IsDigit(split2[1][0]);
        //        if(!isDigit1 && !isDigit2)
        //        {
        //            int cmp = split1[1].CompareTo(split2[1]);
        //            if (cmp != 0) return cmp;
        //            return split1[0].CompareTo(split2[0]);
        //        }
        //        return isDigit1 ? (isDigit2 ? 0 : 1) : -1;
        //    });
        //    List<string> answer = new List<string>(logLines);
        //    return answer;
        //}

        public List<string> reorderLines(int logFileSize, string[] logLines)
        {
            Array.Sort(logLines, CompareLog);
            List<string> result = logLines.OfType<string>().ToList();
            return result;
        }

        public int CompareLog(string log1, string log2)
        {
            string[] split1 = log1.Split(" ", 2); //This will divide string into two part, First part will contain identifier and second part will contain log
            string[] split2 = log2.Split(" ", 2);
            bool isDigit1 = char.IsDigit(split1[1][0]); //if first char is digit then whole string is digit
            bool isDigit2 = char.IsDigit(split2[1][0]);

            if (!isDigit1 && !isDigit2)
            {
                int comStr = split1[1].CompareTo(split2[1]); //split1 > split2 = 1, split1 == split2 = 0, split1 < split2 = -1
                if (comStr != 0) return comStr; //0 means both string are equal. Since here if both string are not equal then it will either return less then 0 (if split[1] is less) or greater than 0 (if split[1] is greater)
                int comidr = split1[0].CompareTo(split2[0]); //if both string are equal then compare identifier
                return comidr;
            }
            //if (digit1 && digit2) return 0; //do not change order if both are digit;
            //else if (digit1) return 1; //if digit1 is digit then we want to keep it at bottom that's why 1
            //else return -1;

            return isDigit1 ? (isDigit2 ? 0 : 1) : -1;
        }
    }
}
