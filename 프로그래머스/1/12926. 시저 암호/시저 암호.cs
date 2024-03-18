using System;
public class Solution {
    public string solution(string s, int n) {
        string answer = "";
        foreach(char c in s)
        {
            if(c!=' ')
            {
                int tmp = 0;
                if((int)c<91)
                {
                    tmp = (int)c + n;
                    if(tmp>90) tmp = 64 + (tmp-90);
                }
                else
                {
                    tmp = (int)c +n;
                    if(tmp>122) tmp = 96 + (tmp-122);
                }
                answer += Convert.ToChar(tmp);
            }
            else
                answer += ' ';
        }
        return answer;
    }
}