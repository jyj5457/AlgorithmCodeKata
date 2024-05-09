using System.Text;
using System;

public class Solution {
    public string solution(string s) {
        //전체 소문자 만들기
        s = s.ToLower();
        StringBuilder answer = new StringBuilder();
        char[] temp = s.ToCharArray();
        
        for(int i = 0; i<temp.Length; i++)
        {
            temp[0] = Char.ToUpper(temp[0]);
            if(temp[i] == ' ' && i+1<temp.Length)
            {
                temp[i+1] = Char.ToUpper(temp[i+1]);
            }
        }
        for(int i = 0; i < temp.Length; i++)
        {
            answer.Append(temp[i]);
        }
        
        return answer.ToString();
    }
}