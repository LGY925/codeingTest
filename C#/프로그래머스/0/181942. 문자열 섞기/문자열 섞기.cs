using System;

public class Solution 
{
    public string solution(string str1, string str2) 
    {
        char[] chars1 = str1.ToCharArray();
        char[] chars2 = str2.ToCharArray();
        char[] totalChars = new char[chars1.Length+chars2.Length];

        for (int i = 0; i < totalChars.Length; i++)
        {
            if (i % 2 == 0)
                totalChars[i] = chars1[i / 2];
            if (i %  2 == 1)
                totalChars[i] = chars2[(i - 1)/2];
        }

        string answer = new string(totalChars);
        return answer;
    }
}