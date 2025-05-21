using System;

public class Solution 
{
    public int solution(int a, int b) 
    {
        string mathA = a.ToString() + b.ToString();
        string mathB = b.ToString() + a.ToString();

        if (mathA.CompareTo(mathB )>0)
        {
            int answer = int.Parse(mathA);
            return answer;
        }
        else
        {
            int answer = int.Parse(mathB);
            return answer;
        }
    }
}