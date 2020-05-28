using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonStack
{
    public class AmazonQuestion2
    {
        public List<string> reorderLines(int logFileSize, string[] logLines)
        {
            Array.Sort(logLines, (log1, log2) =>
            {
                string[] split1 = log1.Split(" ", 2);
                string[] split2 = log2.Split(" ", 2);
                bool isDigit1 = char.IsDigit(split1[1][0]);
                bool isDigit2 = char.IsDigit(split2[1][0]);
                if(!isDigit1 && !isDigit2)
                {
                    int cmp = split1[1].CompareTo(split2[1]);
                    if (cmp != 0) return cmp;
                    return split1[0].CompareTo(split2[0]);
                }
                return isDigit1 ? (isDigit2 ? 0 : 1) : -1;
            });
            List<string> answer = new List<string>(logLines);
            return answer;
        }
        // METHOD SIGNATURE ENDS
    }
}
