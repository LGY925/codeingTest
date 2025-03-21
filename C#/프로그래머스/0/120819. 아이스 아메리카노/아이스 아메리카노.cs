using System;

public class Solution 
{
    public int[] solution(int money) 
    {
        
    int change;
            int n = 0;
            while(5500<=money-5500*n)
            {
                n++;        
            }
            change=money-5500*n;
            int[] answer = new int[] {n,change};
           
            return answer;
    }
}