//part1

using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public string solution(string S)
    {
        char[] schar = S.ToCharArray();
        //  char[] xchar=char.Parse(S);
        // char[] ochar=char.Parse(S);
        int Xcount = 0;
        int Ocount = 0;
        int ResultX = 0;
        int ResultO = 0;

        for (int i = 0; i < S.Length; i++)
        {
            if (schar[i] == 'X')
            {
                Xcount++;


                if (Xcount >= 3)
                {
                    ResultX++;
                    if (ResultX == 1 && ResultO == 1)
                    {
                        ResultO = 0;
                        ResultX = 0;
                        return "tie";
                    }

                }
                Ocount = 0;
            }
            else if (schar[i] == 'O')
            {
                Ocount++;

                if (Ocount >= 3)
                {
                    ResultO++;

                    if (ResultX == 1 && ResultO == 1)
                    {
                        ResultO = 0;
                        ResultX = 0;
                        return "tie";
                    }
                }
                Xcount = 0;
            }
        }
        if (ResultX > ResultO)
        {
            return "X";
        }
        else if (ResultX < ResultO)
        {
            return "O";
        }
        else if (ResultX == ResultO)
        {
            return "tie";
        }
        return null;
        // Implement your solution here
    }
}
3rd
    using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public string solution(string S)
    {
        string largest = "z";
        for(int i=0;i<S.Length;i++)
        {

        }
    }

}
