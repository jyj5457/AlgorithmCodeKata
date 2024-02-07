using System;
public class Solution {
    public long solution(long n) {
        long answer = 0;
        char[] array = n.ToString().ToCharArray();
        Array.Sort(array);
        Array.Reverse(array);
        answer = long.Parse(new string(array));
        return answer;
    }
}