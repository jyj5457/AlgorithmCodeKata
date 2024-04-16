using System;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        int sameIndex = 0;
        int diffIndex = 0;
        char word = ' ';
        bool start = true;
        
        for(int i = 0; i < s.Length; i++)
        {
            if(start == true)
            {
                word = s[i];
                sameIndex++;
                start = false;
            }
            else
            {
                if(s[i] == word)
                {
                    sameIndex++;
                }
                else
                {
                    diffIndex++;
                }
            }
            if(sameIndex == diffIndex)
            {
                answer++;
                sameIndex = 0;
                diffIndex = 0;
                start = true;
            }
            if(i==s.Length -1)
            {
                if(start == false)
                {
                    answer++;
                }
            }
        }
        return answer;
    }
}