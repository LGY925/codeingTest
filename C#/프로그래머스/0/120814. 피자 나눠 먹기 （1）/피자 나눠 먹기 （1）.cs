using System;

public class Solution 
{
    public int solution(int n) 
    {
            int pizza = 0;

            do
            {
                pizza++;
                
            } while (7 * pizza / n < 1);
            
                int answer = pizza;
            return answer;

    }
}