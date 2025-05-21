using System;

public class Solution 
{
    public int solution(int a, int b) 
    {
        int answer = 0;
        int mathA = int.Parse($"{a}{b}");
        int mathB = int.Parse($"{b}{a}");
        if (mathA.CompareTo(mathB) > 0)
        {
            answer = mathA;
        }
        else
        {
            answer = mathB;
        }
        return answer;
    }
}