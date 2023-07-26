1st
// Remember, all submissions are being checked for plagiarism.
// Your recruiter will be informed in case suspicious activity is detected.

using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public int solution(int[] blocks)
    {
        int smallest = blocks[0];//MATH.MIN(BLOCKS);
        int longestPossibleDistanceFAR = 0;
        int longestPossibleDistanceBAC = 0;
        int longestPossibleDistanceANYMID = 0;
        int longest = 0;
        // FIND SMALLEST
        for (int i = 0; i < blocks.Length - 1; i++)
        {
            if (blocks[i] < smallest)
            {
                smallest = blocks[i];
            }

        }

        if (smallest == blocks[0])
        {
            for (int j = 0; j < blocks.Length - 1; j++)
            {
                if (blocks[j + 1] >= blocks[0])
                {
                    longestPossibleDistanceFAR++;
                }
            }

        }
        else if (smallest == blocks[blocks.Length - 1])
        {
            for (int j = blocks.Length - 1; j > 0; j--)
            {
                if (blocks[j - 1] >= blocks[0])
                {
                    longestPossibleDistanceBAC++;
                }
            }

        }
        else if (smallest != blocks[0] || smallest != blocks[blocks.Length - 1])
        {
            int j = 0;
            while (j >= 0)
            {
                if (blocks[j - 1] >= blocks[0])
                {
                    longestPossibleDistanceANYMID++;
                }
                j--;
            }
            while (j < blocks.Length)
            {
                if (blocks[j + 1] >= blocks[0])
                {
                    longestPossibleDistanceFAR++;
                }
                j++;
            }

        }
        if (longestPossibleDistanceFAR > longestPossibleDistanceBAC && longestPossibleDistanceFAR > longestPossibleDistanceANYMID)
        {
            longest = longestPossibleDistanceFAR;
        }
        else if (longestPossibleDistanceBAC > longestPossibleDistanceFAR && longestPossibleDistanceBAC > longestPossibleDistanceANYMID)
        {
            longest = longestPossibleDistanceBAC;
        }
        else if (longestPossibleDistanceANYMID > longestPossibleDistanceFAR && longestPossibleDistanceANYMID > longestPossibleDistanceBAC)
        {
            longest = longestPossibleDistanceANYMID;
        }
        if (longest == 1)
        {
            longest++;
        }
        return longest;

        // Implement your solution here
    }
}
//2nd
using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public string solution(string name, string surname, int age)
    {
        char[] na = name.ToCharArray();
        char[] surna = surname.ToCharArray();
        string newage = Convert.ToString(age);
        //  List<char> RESULT=new List<char>();
        //RESULT.Add(Convert.ToString(na[0]));
        //RESULT.AddAdd(Convert.ToString(na[0]));
        //RESULT.Add(Convert.ToString(na[0]));
        //RESULT.Add(Convert.ToString(na[0]));
        //RESULT.Add(Convert.ToString(na[0]));
        string strRESULT = (Convert.ToString(na[0])) + (Convert.ToString(na[1])) + (Convert.ToString(surna[0])) + (Convert.ToString(surna[1])) + newage;
        return strRESULT;


        // Implement your solution here
    }
}

