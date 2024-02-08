using System;

public class Solution {
    public bool solution(int x) {
        int sum = 0;
        int X = x;
        
        for(;X>0;X/=10)
        {
            sum += (X%10);
        }
        if(x%sum == 0)
            return true;
        else
            return false;
    }
}