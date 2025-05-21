using System;

public class Solution {
    public int solution(int a, int b) 
    {
        string mathA = a.ToString() + b.ToString();
        int total = int.Parse(mathA);
        
        if (total < (2 * a * b))
        {
            total = 2 * a * b;
        }
        int answer = total;
        return answer;
    }
}