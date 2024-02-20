public class Solution {
    public string solution(string phone_number) {
        string answer = "";
        
        string temp = phone_number.Substring(phone_number.Length-4,4);
            
        for(int i = 0; i < phone_number.Length-4; i++)
        {
            answer += "*";
        }
        answer +=temp;
        
        return answer;
    }
}