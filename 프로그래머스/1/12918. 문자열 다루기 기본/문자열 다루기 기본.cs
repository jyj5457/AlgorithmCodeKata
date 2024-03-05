public class Solution {
    public bool solution(string s) {
        
        if(s.Length == 4 || s.Length == 6)
        {
            bool answer = int.TryParse(s, out int n);
            return answer;
        }
        else
        {
            return false;
        }
    }
}