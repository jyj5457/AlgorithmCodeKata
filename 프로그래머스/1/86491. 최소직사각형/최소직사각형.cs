using System;

public class Solution {
    public int solution(int[,] sizes) {
        
        int maxWidth = 0;
        int maxHeigth = 0;
        for(int i = 0; i < sizes.GetLength(0); i++)
        {
            int width = Math.Max(sizes[i,0],sizes[i,1]);
            int heigth = Math.Min(sizes[i,0],sizes[i,1]);
            
            if(maxWidth < width)
                maxWidth = width;
            
            if(maxHeigth < heigth)
                maxHeigth = heigth;
        }
        return maxWidth * maxHeigth;
    }
}