using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] lottos, int[] win_nums) {
        int right = 0;
        int num = 0;
        for(int i = 0; i < lottos.Length; i++)
        {
            if(lottos[i]==0)
            {
                num++;
            }
            if(lottos.Contains(win_nums[i]))
            {
                right++;
            }
        }
        int MaxCollect = num+right;
        int MinCollect = right;
        if(MinCollect==0) MinCollect++;
        if(MaxCollect==0) MaxCollect++;
        int[] answer = new int[] {7-MaxCollect,7-MinCollect};
        return answer;
    }
}