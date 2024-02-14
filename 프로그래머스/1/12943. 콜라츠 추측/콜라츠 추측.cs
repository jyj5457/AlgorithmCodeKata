public class Solution {
    public int solution(int num) {
        int answer = 0;
        long temp = num;
        while (temp != 1)
        {
            ++answer;
            temp = temp % 2 == 0 ? temp / 2 : temp * 3 +1;
            if(answer > 500)
            {
                return -1;
            }
        }
        return answer;
    }
}