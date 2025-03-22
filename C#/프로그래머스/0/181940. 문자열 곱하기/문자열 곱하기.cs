using System;

public class Solution 
{
    public string solution(string my_string, int k) 
    {
        string input = my_string;
        for(int i=1 ; i < k; i++)
        {
            my_string=my_string+input;
        }
        string answer = my_string;
        return answer;
    }
}