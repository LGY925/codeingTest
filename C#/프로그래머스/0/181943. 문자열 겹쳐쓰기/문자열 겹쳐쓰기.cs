using System;

public class Solution 
{

        public string solution(string my_string, string overwrite_string, int s)
        {
            char[] my = my_string.ToCharArray();
            char[] overwrite = overwrite_string.ToCharArray();


            for ( int i = 0 ; i < overwrite.Length; i++)
            {
                my[i + s] = overwrite[i];
            }


            string answer = new string(my);
            return answer;
        }
}