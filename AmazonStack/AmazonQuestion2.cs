using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        private int CompareLines(string log1, string log2)
        {
            string[] split1 = log1.Split(" ", 2); //it actually dividing whole string into two parts. 
            string[] split2 = log2.Split(" ", 2); //so split1[0] will have identifier and split1[1] will have remaining string
            bool isDigit1 = char.IsDigit(split1[1][0]);
            bool isDigit2 = char.IsDigit(split2[1][0]);
            if(!isDigit1 && !isDigit2)
            {
                int cmp = split1[1].CompareTo(split2[1]);
                if (cmp != 0) return cmp; //0 means both string are equal. Since here if both string are not equal then it will either return less then 0 (if split[1] is less) or greater than 0 (if split[1] is greater)
                return split1[0].CompareTo(split2[0]); //if both string are equal then compare identifier
            }
            int ans = isDigit1 ? (isDigit2 ? 0 : 1) : -1;
            return ans;
        }

        public int CompareLog(string log1, string log2)
        {
            string[] split1 = log1.Split(" ", 2); //This will divide string into two part, First part will contain identifier and second part will contain log
            string[] split2 = log2.Split(" ", 2);
            bool digit1 = char.IsDigit(split1[1][0]); //if first char is digit then whole string is digit
            bool digit2 = char.IsDigit(split2[1][0]);

            if (!digit1 && !digit2)
            {
                int comStr = split1[1].CompareTo(split2[1]); //split1 > split2 = 1, split1 == split2 = 0, split1 < split2 = -1
                if (comStr != 0) return comStr; //if both string are not same
                int comidr = split1[0].CompareTo(split2[0]);
                return comidr;
            }
            //if (digit1 && digit2) return 0; //do not change order if both are digit;
            //else if (digit1) return -1; //if digit1 is digit then we want to keep it at bottom that's why 1
            //else return -1;

            return digit1 ? (digit2 ? 0 : 1) : -1;
        }
        // METHOD SIGNATURE ENDS
    }
}
