using System;

public class Solution 
{
    public int solution(string ineq, string eq, int n, int m) 
    {
        int answer = 0;
        if ( ineq == ">")
        {
            if(eq == "=")
            {
                if(n>=m)
                {
                    answer++;
                }
            }
            if(eq == "!")
            {
                if(n > m)
                {
                    answer++;
                }
            }
        }
        else if(( ineq == "<"))
        {
            if(eq == "=")
            {
                if(n<=m)
                {
                    answer++;
                }
            }
            if(eq == "!")
            {
                if(n < m)
                {
                    answer++;
                }
            }
        }
        
        
        return answer;
    }
}