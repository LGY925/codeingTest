using System;

public class Solution 
{
    public int solution(int[] array, int height) 
    {
        int count = 0;
        foreach(int arr in array)
        {
            if(arr > height)
            {
                count++;
            }
        }
        int answer = count;
        return answer;
    }
}