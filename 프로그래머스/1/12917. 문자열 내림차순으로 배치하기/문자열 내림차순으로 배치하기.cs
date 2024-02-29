using System;
using System.Linq;

public class Solution {
    public string solution(string s) {
        string answer = "";
        //문자열을 각각의 단일문자로 저장
        char[] temp = s.ToCharArray();
        //배열을 내림차순으로 정렬 (오름차순 후 역순)
        Array.Sort(temp);
        Array.Reverse(temp);
        //단일문자 배열을 다시 문자열로 변환
        answer = new string(temp);
        return answer;
    }
}