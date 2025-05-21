using System;

public class Solution {
    public int solution(int a, int b) 
    {
        int total = int.Parse($"{a}{b}");
        
        if (total < (2 * a * b))
        {
            total = 2 * a * b;
        }
        int answer = total;
        return answer;
    }
}