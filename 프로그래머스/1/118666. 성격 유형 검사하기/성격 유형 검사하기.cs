public class Solution
{
    public string solution(string[] survey, int[] choices)
    {
        string answer = "";
        string[,] keys = new string[4, 2]
        {
            {"R", "T" }, {"C", "F" }, {"J","M"}, {"A","N"}
        };
        int[,] values = new int[4, 2];

        for (int i = 0; i < survey.Length; i++)
        {
            string sSurvey = "";
            int choice = 0;

            if (choices[i] > 4) 
            {
                sSurvey = survey[i][1].ToString(); 
                choice = (-1) * (4 - choices[i]); 
            }
            else 
            {
                sSurvey = survey[i][0].ToString(); 
                choice = 4 - choices[i]; 
            }
            
            for (int j = 0; j < 4; j++) 
            {
                for (int k = 0; k < 2; k++) 
                {
                    if (keys[j, k] == sSurvey) 
                    {
                        values[j, k] += choice;  
                    }
                }
            }
        }

        for (int i = 0; i < 4; i++) 
        {
            if (values[i, 0] >= values[i, 1]) 
                answer += keys[i, 0]; 
            else if (values[i, 0] < values[i, 1]) 
                answer += keys[i, 1]; 
        }
        return answer;
    }
}