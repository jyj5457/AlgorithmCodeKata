using System.Linq;

public class Solution {
    public string solution(string s) {
        string answer = "";

            // 문자열 배열에 있는 요소들을 int로 형변환
            int[] temp = s.Split(' ').Select(int.Parse).ToArray();

            // 정답형식에 맞게 문자열 완성
            answer = temp.Min().ToString() + " " +temp.Max().ToString();

            return answer;
    }
}