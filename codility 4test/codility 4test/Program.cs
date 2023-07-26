// Codility contest 4 
// 2nd part
using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public int solution(string S)
    {
        int ANO = 0;
        int BNO = 0;
        int NNO = 0;
        int NO = 0;// NO MATCHING
        int maxNoOfTimes = 0;

        Char[] schar = S.ToCharArray();
        for (int i = 0; i < schar.Length; i++)
        {

            if (schar[i] == 'A')
            {
                ANO++;
            }
            else if (schar[i] == 'B')
            {
                BNO++;
            }
            else if (schar[i] == 'N')
            {
                NNO++;
            }

        }         //
        if (ANO >= 3 && BNO >= 1 && NNO >= 2)
        {

            maxNoOfTimes++;
            ANO -= 3;
            BNO -= 1;
            NNO -= 2;
            if (ANO >= 3 && BNO >= 1 && NNO >= 2)
            {
                maxNoOfTimes++;
                ANO -= 3;
                BNO -= 1;
                NNO -= 2;
            }


        }
        return maxNoOfTimes;

        // Implement your solution here
    }
}
//3rd part
using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public int solution(int A, int B)
    {
        int Totalsum = A + B;
        int requirdReturn = 0;
        for (int i = (A + B) / 3; i >= 1; i--)
        {
            if (A / i >= 3 && B / i >= 1)
            {
                requirdReturn = i;
                break;
            }
            else if (A / i >= 4 && B / i >= 0)
            {
                requirdReturn = i;
                break;
            }
            else if (A / i >= 2 && B / i >= 2)
            {
                requirdReturn = i;
                break;
            }
            else if (A / i >= 1 && B / i >= 3)
            {
                requirdReturn = i;
                break;
            }
            else if (A / i >= 0 && B / i >= 4)
            {
                requirdReturn = i;
                break;
            }
        }
        return requirdReturn;
        // Implement your solution here
    }
}
